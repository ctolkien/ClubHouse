using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    internal class EpicResource : Resource<Epic, int>, IEpicResource
    {
        protected override string ResourceName => "epics";

        internal EpicResource(ClubHouseHttpClient client) : base(client)
        {
        }

        //TODO: Clean this up
        public Task<Epic> Update(Epic model, int afterId = 0, int beforeId = 0)
        {
            if (afterId > 0)
            {
                var foo = (EpicUpdate)model;
                foo.AfterId = afterId;
                return base.Update(model);
            }
            else if (beforeId > 0) {
                var foo = (EpicUpdate)model;
                foo.BeforeId = afterId;
                return base.Update(model);

            }
            return base.Update(model);
        }

    }

    public interface IEpicResource : IEpicResource<Epic, int> { }

    public interface IEpicResource<TModel, TKey> :
        IListable<TModel>,
        ICreateable<TModel>,
        IGettable<TModel, TKey>,
        IUpdateable<TModel>,
        IDeletable<TKey>
    {
    }
}
