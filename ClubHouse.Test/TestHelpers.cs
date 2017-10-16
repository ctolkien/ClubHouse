namespace ClubHouse.Test
{
    public static class TestHelpers
    {
        public static ClubHouseClient CreateClient()
        {
            var apiKey = System.Environment.GetEnvironmentVariable("CLUBHOUSE_APIKEY");
            //var client = new ClubHouseClient(apiKey, new MockedResponseHandler().Epic());
            var client = new ClubHouseClient(apiKey);
            return client;
        }
    }
}
