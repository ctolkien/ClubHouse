using ClubHouse.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class StoryTests
    {
        [Fact]
        public async Task CreateMultipleStories()
        {
            var client = CreateClient();

            var result = await client.Stories.Create(new Story[]
            {
                new Story { Name = "Here is my NEW story", ProjectId = 6, Archived = false, Tasks = new List<StoryTask> {
                    new StoryTask { Description="Here we go" } } },
                new Story { Name = "Here is my NEW second story", ProjectId = 6, Archived = true },
            });

            Assert.Equal(2, result.Count);

        }

        [Fact]
        public async Task StorySearch()
        {
            var client = CreateClient();

            var search = new StorySearch
            {
                LabelName = "This is my test label #2"
            };

            var result = await client.Stories.Search(search);

            Assert.Equal(2, result.Count);

        }
    }
}
