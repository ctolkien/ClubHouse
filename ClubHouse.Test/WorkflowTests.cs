using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class WorkflowTests
    {
        [Fact]
        public async Task List()
        {
            var client = CreateClient(new MockedResponseHandler().Workflows());

            var results = await client.Workflows.List();

            Assert.Equal(1, results.Count);
        }
    }
}
