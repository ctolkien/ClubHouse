using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClubHouse.Test
{
    public class ProjectTests : TestBase
    {

        [Fact]
        public async Task ListProjects()
        {
            var client = CreateClient();

            var foo = await client.Projects.List();
        }

        [Fact]
        public async Task GetProject()
        {
            var client = CreateClient();

            var foo = await client.Projects.Get(6);

            Assert.Equal("iNemesis", foo.Name);

        }

        [Fact]
        public async Task UpdateProject()
        {
            var client = CreateClient();

            var result = await client.Projects.Update(new Models.Project
            {
                Id = 6,
                Color = "Red"
            });

            Assert.Equal("Red", result.Color);

        }
    }
}
