using System.Net.Http;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class CommentResource : Resource<Comment, int>, ICommentResource
    {
        private readonly int _parentItemId;

        protected override string ResourceName => $"{_parentItemId}/comments";

        internal CommentResource(int parentItemId, HttpClient client) : base(client)
        {
            _parentItemId = parentItemId;
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
