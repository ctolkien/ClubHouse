using ClubHouse.Exceptions;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace ClubHouse
{
    internal class ClubHouseHttpMessageHandler : DelegatingHandler
    {
        private readonly Func<string> _apiToken;

        public ClubHouseHttpMessageHandler(Func<string> apiToken) : base(new HttpClientHandler())
        {
            _apiToken = apiToken;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = _apiToken();
            var builder = new UriBuilder(request.RequestUri);
            //This is ugly as sin, but is the method outlined here:
            //https://msdn.microsoft.com/en-us/library/system.uribuilder.query(v=vs.110).aspx
            if (builder.Query?.Length > 1)
            {
                builder.Query = builder.Query.Substring(1) + $"&token={token}";
            }
            else
            {
                builder.Query = $"?token={token}";
            }

            request.RequestUri = builder.Uri;

            if (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put)
            {
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            //perform the request
            var result = await base.SendAsync(request, cancellationToken);

            //now we deal with the result
            if (!result.IsSuccessStatusCode)
            {
                //let's try and decode the msg...
                var msgResult = Newtonsoft.Json.JsonConvert.DeserializeObject<ClubHouseErrorResponse>(await result.Content.ReadAsStringAsync());
                switch (result.StatusCode)
                {
                    case HttpStatusCode.Unauthorized:
                        throw new NotAuthorizedException(msgResult.ToString());
                    case HttpStatusCode.BadRequest:
                        throw new BadRequestException(msgResult.ToString());
                    case HttpStatusCode.NotFound:
                        throw new NotFoundException(msgResult.ToString());
                    case ((HttpStatusCode)422):
                        throw new UnprocessableException(msgResult.ToString());
                }
            }

            return result;
        }
    }
}
