using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;


namespace ClubHouse.Test
{
    public class UserTests
    {
        [Fact]
        public async Task List()
        {
            var client = CreateClient();

            var users = await client.Users.List();

            Assert.Equal(1, users.Count);
        }

        [Fact]
        public async Task GetUser()
        {
            var client = CreateClient();

            var users = await client.Users.Get("58c31cfd-6cf0-42c8-9689-45b31f2374cb");

            Assert.Equal("Chad Tolkien", users.Name);
        }
    }
}
