using ClubHouse.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace ClubHouse.Resources
{
    internal class StoryResource : Resource<Story, int>, IStoryResource
    {
        protected override string ResourceName => "stories";

        internal StoryResource(HttpClient client) : base(client)
        {
        }

        public ITaskResource Tasks(int id) => new TaskResource(id, _client);

        public ICommentResource Comments(int id) => new CommentResource(id, _client);

        public Task<IReadOnlyList<Story>> Create(IEnumerable<Story> stories)
        {
           return base.Create<Story, IReadOnlyList<Story>>(stories);
        }

        public Task<IReadOnlyList<Story>> Update(IEnumerable<Story> stories)
        {
            return base.Update<Story, IReadOnlyList<Story>>(stories);
        }

        public Task<IReadOnlyList<Story>> Search(StorySearch search)
        {
            //Note, that we use create here, as it under the covers is a 'post'
            //this should probably be exposed a bit better from the base class.
            return Create<IReadOnlyList<Story>>(search, "stories/search");
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

        /// <summary>
        /// Batch create a collection of Stories
        /// </summary>
        /// <param name="stories"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Story>> Create(IEnumerable<Story> stories);

        /// <summary>
        /// Batch update a colection of Stories
        /// </summary>
        /// <param name="stories"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Story>> Update(IEnumerable<Story> stories);

        /// <summary>
        /// Search Clubhouse Stories for those matching the provided <see cref="StorySearch"/>
        /// </summary>
        /// <param name="search">The search requirements</param>
        /// <returns>A list of matching stories</returns>
        Task<IReadOnlyList<Story>> Search(StorySearch search);
    }
}
