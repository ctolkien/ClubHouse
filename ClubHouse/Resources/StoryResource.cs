using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class StoryResource : Resource<Story, int>, IStoryResource
    {
        protected override string ResourceName => "stories";



        public StoryResource(ClubHouseHttpClient client) : base(client)
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

    public interface IStoryResource : IStoryResource<Story, int>
    {
        ITaskResource Tasks(int id);
        ICommentResource Comments(int id);

    }

    public interface IStoryResource<TModel, TKey> :
        ICreateable<TModel, TModel, TKey>,
        IGettable<TModel, TKey>,
        IUpdateable<TModel, TModel, TKey>,
        IDeletable<TKey>
        where TModel : ClubHouseModel<TKey>
    {

    }
}
