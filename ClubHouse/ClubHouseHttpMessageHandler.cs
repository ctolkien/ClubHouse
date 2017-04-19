using ClubHouse.Exceptions;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ClubHouse
{
    internal class ClubHouseHttpMessageHandler : DelegatingHandler
    {
        private readonly string _apiToken;

        public ClubHouseHttpMessageHandler(string apiToken) : base(new HttpClientHandler())
        {
            _apiToken = apiToken;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var builder = new UriBuilder(request.RequestUri)
            {
                //TODO: Find a less stringy way of doing this...
                Query = $"?token={_apiToken}"
            };
            request.RequestUri = builder.Uri;

            //todo find a better way to filter this based on requests which can have a body...
            if (request.Content != null)
            {
                request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            }

            //perform the request
            var result = await base.SendAsync(request, cancellationToken);

            if (!result.IsSuccessStatusCode)
            {
                //let's try and decode the msg...
                var msgResult = Newtonsoft.Json.JsonConvert.DeserializeObject<ClubHouseErrorResponse>(await result.Content.ReadAsStringAsync());
                switch (result.StatusCode)
                {
                    case System.Net.HttpStatusCode.Unauthorized:
                        throw new NotAuthorizedException(msgResult.ToString());
                    case System.Net.HttpStatusCode.BadRequest:
                        throw new BadRequestException(msgResult.ToString());
                    case System.Net.HttpStatusCode.NotFound:
                        throw new NotFoundException(msgResult.ToString());
                    case ((System.Net.HttpStatusCode)422):
                        throw new UnprocessableException(msgResult.ToString());
                }
            }

            return result;
        }
    }
}
