using System.Net.Http;


namespace ClubHouse
{
    public class ClubHouseHttpClient : HttpClient
    {
        private readonly string _apiToken;
        public ClubHouseHttpClient(string apiToken) : this(apiToken, new ClubHouseHttpMessageHandler(apiToken))
        {
            _apiToken = apiToken;

        }

        public ClubHouseHttpClient(string apiToken, HttpMessageHandler messageHandler) : base(messageHandler)
        {

            _apiToken = apiToken;
        }

    }
}
