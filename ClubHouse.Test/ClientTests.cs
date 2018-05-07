using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ClubHouse.Test
{
    public class ClienTests
    {
        private readonly ITestOutputHelper _output;

        public ClienTests(ITestOutputHelper output)
        {
            this._output = output;
        }


        [Fact]
        public async Task CreateClientWithFuncApiKeyShouldChangeToken()
        {
            var client = new ClubHouseClient(() => DateTime.UtcNow.Ticks.ToString());

            var result1 = await client._httpClient.GetAsync("https://www.sodadigital.com.au");

            Thread.Sleep(1000);
            var result2 = await client._httpClient.GetAsync("https://www.sodadigital.com.au");

            _output.WriteLine(result1.RequestMessage.RequestUri.ToString());
            _output.WriteLine(result2.RequestMessage.RequestUri.ToString());

        }
    }
}