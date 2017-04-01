using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class CommentResource : Resource<Comment, int>, ICommentResource
    {
        private readonly int _storyId;

        protected override string ResourceName => $"{_storyId}/comments";
        public CommentResource(int storyId, ClubHouseHttpClient client) : base(client)
        {
            _storyId = storyId;
        }

    }

    public interface ICommentResource : ICommentResource<Comment, int>
    {

    }
    public interface ICommentResource<TModel, TKey> :
        ICreateable<TModel, TModel, TKey>,
        IUpdateable<TModel, TModel, TKey>,
        IGettable<TModel, TKey>,
        IDeletable<TKey>
        where TModel : ClubHouseModel<TKey>
    {

    }
}
