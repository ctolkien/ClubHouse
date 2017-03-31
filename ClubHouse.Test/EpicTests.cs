using ClubHouse.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ClubHouse.Test
{
    public class EpicTests : TestBase
    {

        [Fact]
        public async Task GetEpic()
        {
            var client = CreateClient();

            var foo = await client.Epics.Get(10);

            Assert.Equal(10, foo.Id);
            Assert.Equal(EpicState.InProgress, foo.State);
        }

        [Fact]
        public async Task UpdateEpic()
        {
            var client = CreateClient();

            var e = new Epic
            {
                Id = 10,
                Name = "new epic name",
                State = EpicState.InProgress
            };

            await client.Epics.Update(e);
        }

        [Fact]
        public async Task ListEpics()
        {
            var client = CreateClient();

            var foo = await client.Epics.List();

            Assert.Equal(1, foo.Count);
        }

        [Fact]
        public async Task CreateEpics()
        {
            var client = CreateClient();

            var foo = await client.Epics.Create(new Epic
            {
                Name = "Wasahhh"
            });

            Assert.Equal("Wasahhh", foo.Name);
        }


        [Fact]
        public async Task UpdateEpicSettingBeforeId()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public async Task UpdateEpicSettingAfterId()
        {
            throw new NotImplementedException();
        }
    }
}
