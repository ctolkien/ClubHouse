using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;


namespace ClubHouse.Test
{
    public class LinkedFileTests
    {
        [Fact]
        public async Task List()
        {
            var client = CreateClient();

            var result = await client.LinkedFiles.List();

            Assert.Equal(1, result.Count);
            Assert.Equal("http://i.imgur.com/VoS7VQB.jpg", result[0].Url);
        }

        [Fact]
        public async Task Create()
        {
            var client = CreateClient();

            var result = await client.LinkedFiles.Create(new Models.LinkedFile
            {
                Url = "http://i.imgur.com/VoS7VQB.jpg",
                Name = "test name",
                Type = Models.LinkedFileType.Url
            });

            Assert.Equal("test name", result.Name);
        }
    }
}
