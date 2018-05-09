namespace ClubHouse.Test
{
    internal static class TestHelpers
    {
        internal static ClubHouseClient CreateClient(string apiKey) => new ClubHouseClient(apiKey);

        internal static ClubHouseClient CreateClient(MockedResponseHandler handler) => new ClubHouseClient(handler);
    }
}
