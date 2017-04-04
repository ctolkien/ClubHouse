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
    }
}
