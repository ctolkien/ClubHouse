using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClubHouse.Test
{
    public class UserTests : TestBase
    {
        [Fact]
        public async Task ListUsers()
        {
            var client = CreateClient();

            var users = await client.Users.List();

            Assert.Equal(1, users.Count);
        }

        [Fact]
        public async Task GetUser()
        {
            var client = CreateClient();

            var users = await client.Users.Get("asd");

            Assert.Equal("Chad", users.Name);
        }
    }
}
