using ClubHouse.Models;
using System.Threading.Tasks;
using System;

namespace ClubHouse.Resources
{
    internal class EpicResource : Resource<Epic, int>, IEpicResource
    {
        protected override string ResourceName => "epics";

        internal EpicResource(ClubHouseHttpClient client) : base(client)
        {
        }

        public Task<Epic> Update(EpicUpdate model)
        {
            return Update(model);
        }


    }

    public interface IEpicResource : IEpicResource<Epic, int> { }

    public interface IEpicResource<TModel, TKey> :
        IListable<TModel, TKey>,
        ICreateable<TModel, TModel, TKey>,
        IGettable<TModel, TKey>,
        IUpdateable<TModel, EpicUpdate, int>,
        IDeletable<TKey> where TModel : ClubHouseModel<TKey>
    {
    }
}
