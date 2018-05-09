using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class ProjectTests
    {
        [Fact]
        public async Task List()
        {
            var client = CreateClient(new MockedResponseHandler().Projects());

            var result = await client.Projects.List();

            Assert.Equal(1, result.Count);
        }

        [Fact]
        public async Task GetProject()
        {
            var client = CreateClient(new MockedResponseHandler().Projects());

            var result = await client.Projects.Get(6);

            Assert.Equal("sample project", result.Name);
        }

        [Fact]
        public async Task UpdateProject()
        {
            var client = CreateClient(new MockedResponseHandler().Projects());

            var result = await client.Projects.Update(new Models.Project
            {
                Id = 6,
                Color = "Red"
            });

            Assert.Equal("Red", result.Color);
        }
    }
}
