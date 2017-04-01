using System.Net.Http;


namespace ClubHouse
{
    public class ClubHouseHttpClient : HttpClient
    {
        public ClubHouseHttpClient(string apiToken) : this(apiToken, new ClubHouseHttpMessageHandler(apiToken))
        {
        }


        internal ClubHouseHttpClient(string apiToken, HttpMessageHandler messageHandler) : base(messageHandler)
        {
        }

    }
}
