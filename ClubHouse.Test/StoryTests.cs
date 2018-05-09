using ClubHouse.Models;
using System.Collections.Generic;
using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class StoryTests
    {
        [Fact]
        public async System.Threading.Tasks.Task CreateMultipleStories()
        {
            var client = CreateClient(new MockedResponseHandler().Stories());

            var result = await client.Stories.Create(new Story[]
            {
                new Story { Name = "Here is my NEW story", ProjectId = 6, Archived = false, Tasks = new List<Task> {
                    new Task { Description="Here we go" } } },
                new Story { Name = "Here is my NEW second story", ProjectId = 6, Archived = true },
            });

            Assert.Equal(2, result.Count);
        }


    }
}
