namespace ClubHouse.Test
{
    public static class TestHelpers
    {
        private const string apiKey = "";

        public static ClubHouseClient CreateClient()
        {
            //var client = new ClubHouseClient(apiKey, new MockedResponseHandler().Epic());
            var client = new ClubHouseClient(apiKey);
            return client;
        }
    }
}
