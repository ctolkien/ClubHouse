namespace ClubHouse.Test
{
    public static class TestHelpers
    {
        private const string apiKey = "";
        public static ClubHouseClient CreateClient()
        {
            return new ClubHouseClient(apiKey);
        }
    }
}
