using System;
using System.Net.Http;

namespace ClubHouse
{
    public class ClubHouseHttpClient : HttpClient
    {
        internal ClubHouseHttpClient(string apiToken, string endPoint) :
            this(apiToken, endPoint, new ClubHouseHttpMessageHandler(apiToken))
        {
        }

        internal ClubHouseHttpClient(string apiToken, string endPoint, HttpMessageHandler messageHandler) : base(messageHandler)
        {
            BaseAddress = new Uri(endPoint);
        }
    }
}
