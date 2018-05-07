using ClubHouse.Models;
using System.Threading.Tasks;
using System.Net.Http;

namespace ClubHouse.Resources
{
    internal class EpicResource : Resource<Epic, int>, IEpicResource
    {
        protected override string ResourceName => "epics";

        internal EpicResource(HttpClient client) : base(client)
        {
        }

        public Task<Epic> Create(EpicCreate model) => base.Update(model);

        public Task<Epic> Update(EpicUpdate model) => base.Update(model);

        public ICommentResource Comments(int id) => new CommentResource(id, _client);
    }

    public interface IEpicResource :
        IListable<Epic, int>,
        ICreateable<Epic, EpicCreate, int>,
        IGettable<Epic, int>,
        IUpdateable<Epic, EpicUpdate, int>,
        IDeletable<int>

    {
        ICommentResource Comments(int id);
    }
}
