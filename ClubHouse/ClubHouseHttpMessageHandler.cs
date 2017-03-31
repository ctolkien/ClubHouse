using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("ClubHouse.Test")]
namespace ClubHouse
{
    internal class ClubHouseHttpMessageHandler : DelegatingHandler
    {
        private readonly string _apiToken;

        public ClubHouseHttpMessageHandler(string apiToken) : base(new HttpClientHandler())
        {

            _apiToken = apiToken;
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
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

            return base.SendAsync(request, cancellationToken);
        }
    }
}
