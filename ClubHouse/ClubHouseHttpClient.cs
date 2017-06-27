using System;
using System.Net.Http;

namespace ClubHouse
{
    /// <summary>
    /// Specialised <see cref="HttpClient"/> which sets the BaseAddress for the client.
    /// </summary>
    internal class ClubHouseHttpClient : HttpClient
    {
        internal ClubHouseHttpClient(string endPoint, HttpMessageHandler messageHandler)
        : base(messageHandler)
        {
            BaseAddress = new Uri(endPoint);
        }
    }
}
