namespace ClubHouse.Test
{
    internal static class TestHelpers
    {
        internal static ClubHouseClient CreateClient()
        {
            var apiKey = System.Environment.GetEnvironmentVariable("CLUBHOUSE_APIKEY");

            var client = new ClubHouseClient(new MockedResponseHandler().Epic());
            //var client = new ClubHouseClient(apiKey);
            return client;
        }

        internal static ClubHouseClient CreateClient(MockedResponseHandler handler) => new ClubHouseClient(handler);
    }
}
