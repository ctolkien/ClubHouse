using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class CategoryTests
    {
        [Fact]
        public async System.Threading.Tasks.Task ListCategories()
        {
            var client = CreateClient();

            var response = await client.Categories.List();

            Assert.Equal(1, response.Count);
        }

        [Fact]
        public async System.Threading.Tasks.Task CreateCategory()
        {
            var client = CreateClient();

            var response = await client.Categories.Create(new Models.Category
            {
                Name = "Test Category"
            });

            Assert.NotEqual(0, response.Id);
        }

        [Fact]
        public async System.Threading.Tasks.Task GetCategory()
        {
            var client = CreateClient();

            var response = await client.Categories.Get(497);

            Assert.Equal("Test Category", response.Name);
        }

        [Fact]
        public async System.Threading.Tasks.Task UpdateCategory()
        {
            var client = CreateClient();

            var response = await client.Categories.Get(497);

            response.Color = "#ff0000";
            response.Name = "Test Category 2";

            var updated = await client.Categories.Update(response);

            Assert.Equal("#ff0000", updated.Color);
        }

        [Fact]
        public async System.Threading.Tasks.Task DeleteCategory()
        {
            var client = CreateClient();

            await client.Categories.Delete(497);
        }
    }
}
