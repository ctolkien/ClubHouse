using System.Linq;
using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class CategoryTests
    {
        [Fact]
        public async System.Threading.Tasks.Task ListCategories()
        {
            var client = CreateClient(new MockedResponseHandler().Categories());

            var response = await client.Categories.List();

            Assert.Equal(1, response.Count);
            Assert.Equal("foo", response.First().Name);
        }

        [Fact]
        public async System.Threading.Tasks.Task CreateCategory()
        {
            var client = CreateClient(new MockedResponseHandler().Categories());

            var response = await client.Categories.Create(new Models.Category
            {
                Name = "Test Category"
            });

            Assert.Equal("Test Category", response.Name);
        }

        [Fact]
        public async System.Threading.Tasks.Task GetCategory()
        {
            var client = CreateClient(new MockedResponseHandler().Categories());

            var response = await client.Categories.Get(497);

            Assert.Equal("foo", response.Name);
        }

        [Fact]
        public async System.Threading.Tasks.Task UpdateCategory()
        {
            var client = CreateClient(new MockedResponseHandler().Categories());

            var response = await client.Categories.Get(497);

            response.Color = "#ff0000";
            response.Name = "Test Category 2";

            var updated = await client.Categories.Update(response);

            Assert.Equal("#ff0000", updated.Color);
            Assert.Equal("Test Category 2", updated.Name);
        }

        [Fact]
        public async System.Threading.Tasks.Task DeleteCategory()
        {
            var client = CreateClient(new MockedResponseHandler().Categories());

            await client.Categories.Delete(497);
        }
    }
}
