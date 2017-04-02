using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class CommentResource : Resource<Comment, int>, ICommentResource
    {
        private readonly int _storyId;

        protected override string ResourceName => $"{_storyId}/comments";
        internal CommentResource(int storyId, ClubHouseHttpClient client) : base(client)
        {
            _storyId = storyId;
        }

    }

    public interface ICommentResource :
        ICreateable<Comment, Comment, int>,
        IUpdateable<Comment, Comment, int>,
        IGettable<Comment, int>,
        IDeletable<int>
    {
    }
}
