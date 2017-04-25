﻿using System;
using System.Net.Http;

namespace ClubHouse
{
    internal class ClubHouseHttpClient : HttpClient
    {
        internal ClubHouseHttpClient(string endPoint, HttpMessageHandler messageHandler) 
        : base(messageHandler)
        {
            BaseAddress = new Uri(endPoint);
        }
    }
}
