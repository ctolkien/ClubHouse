using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class FileTests
    {
        [Fact]
        public async System.Threading.Tasks.Task List()
        {
            var client = CreateClient(new MockedResponseHandler().Files());
            var list = await client.Files.List();

            Assert.Equal(1, list.Count);
        }

        [Fact]
        public async System.Threading.Tasks.Task Update()
        {
            var client = CreateClient(new MockedResponseHandler().Files());

            var result = await client.Files.Update(new Models.File
            {
                Id = 123,
                Description = "Here is the new description"
            });

            Assert.Equal("Here is the new description", result.Description);
        }
    }
}
