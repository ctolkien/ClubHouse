namespace ClubHouse.Test
{
    public abstract class TestBase
    {
        protected static ClubHouseClient CreateClient()
        {
            return new ClubHouseClient("");
        }
    }
}
