using ClubHouse.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    internal class StoryResource : Resource<Story, int>, IStoryResource
    {
        protected override string ResourceName => "stories";

        internal StoryResource(ClubHouseHttpClient client) : base(client)
        {
        }

        public ITaskResource Tasks(int id)
        {
            return new TaskResource(id, _client);
        }

        public ICommentResource Comments(int id)
        {
            return new CommentResource(id, _client);
        }

        public async Task<IReadOnlyList<Story>> Create(IEnumerable<Story> stories)
        {
           return await base.Create<Story, IReadOnlyList<Story>>(stories);
        }

        public async Task<IReadOnlyList<Story>> Update(IEnumerable<Story> stories)
        {
            return await base.Update<Story, IReadOnlyList<Story>>(stories);
        }

    }

    public interface IStoryResource :
        ICreateable<Story, Story, int>,
        IGettable<Story, int>,
        IUpdateable<Story, Story, int>,
        IDeletable<int>
    {
        ITaskResource Tasks(int id);
        ICommentResource Comments(int id);

        Task<IReadOnlyList<Story>> Create(IEnumerable<Story> stories);
        Task<IReadOnlyList<Story>> Update(IEnumerable<Story> stories);

    }
}
