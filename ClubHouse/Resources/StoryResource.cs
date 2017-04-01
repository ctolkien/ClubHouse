using ClubHouse.Models;

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

        //todo create multiple
        //todo update multiple
    }

    public interface IStoryResource :
        ICreateable<Story, Story, int>,
        IGettable<Story, int>,
        IUpdateable<Story, Story, int>,
        IDeletable<int>
    {
        ITaskResource Tasks(int id);
        ICommentResource Comments(int id);

    }

}
