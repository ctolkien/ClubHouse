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
        private readonly ITestOutputHelper output;

        public ClienTests(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public async Task CreateClientWithFuncApiKeyShouldChangeToken()
        {
            var client = new ClubHouseClient(() => DateTime.UtcNow.Ticks.ToString());

            var result1 = await client.HttpClient.GetAsync("https://www.sodadigital.com.au");

            Thread.Sleep(1000);
            var result2 = await client.HttpClient.GetAsync("https://www.sodadigital.com.au");

            output.WriteLine(result1.RequestMessage.RequestUri.ToString());
            output.WriteLine(result2.RequestMessage.RequestUri.ToString());



        }
    }
}