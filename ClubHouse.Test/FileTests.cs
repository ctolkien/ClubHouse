using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class FileTests
    {
        [Fact]
        public async Task List()
        {
            var client = CreateClient();
            var list = await client.Files.List();

            Assert.Equal(1, list.Count);
        }

        [Fact]
        public async Task Update()
        {
            var client = CreateClient();

            await client.Files.Update(new Models.File
            {
                Id = 43,
                Description = "Here is the new description"
            });

        }
    }
}
