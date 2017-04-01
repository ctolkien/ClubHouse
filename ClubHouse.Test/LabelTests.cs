using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;


namespace ClubHouse.Test
{
    public class LabelTests
    {
        [Fact]
        public async Task CreateLabel()
        {
            var client = CreateClient();

            var label = await client.Labels.Create(new Models.Label
            {
                Name = "This is my test label #2"
            });

            await client.Labels.Update(new Models.Label());


            Assert.Equal(0, label.NumStoriesCompleted);
        }
    }
}
