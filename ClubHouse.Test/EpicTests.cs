using System.Threading.Tasks;
using Xunit;
using static ClubHouse.Test.TestHelpers;

namespace ClubHouse.Test
{
    public class EpicTests
    {
        [Fact]
        public async Task GetEpic()
        {
            var client = CreateClient(new MockedResponseHandler().Epic());

            var response = await client.Epics.Get(123);

            Assert.Equal(123, response.Id);
            Assert.Equal(Models.EpicState.ToDo, response.State);
        }

        [Fact]
        public async Task UpdateEpic()
        {
            var client = CreateClient(new MockedResponseHandler().Epic());

            var e = new Models.EpicUpdate
            {
                Id = 500,
                Name = "new epic name #2",
                State = Models.EpicState.InProgress
            };

            await client.Epics.Update(e);
        }

        [Fact]
        public async Task ListEpics()
        {
            var client = CreateClient(new MockedResponseHandler().Epic());

            var foo = await client.Epics.List();

            Assert.Equal(2, foo.Count);
        }

        [Fact]
        public async Task CreateEpic()
        {
            var client = CreateClient(new MockedResponseHandler().Epic());

            var foo = await client.Epics.Create(new Models.EpicCreate
            {
                Name = "foo"
            });

            Assert.Equal("foo", foo.Name);
        }

        [Fact]
        public async Task DeleteEpic()
        {
            var client = CreateClient(new MockedResponseHandler().Epic());
            await client.Epics.Delete(500);
        }
    }
}
