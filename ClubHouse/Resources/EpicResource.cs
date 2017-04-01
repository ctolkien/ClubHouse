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

        public Task<Epic> Create(Epic model)
        {
            return base.Create(model);
        }

        public Task<Epic> Update(Epic model)
        {
            return base.Create(model);
        }


        //TODO: Add options for setting position
    }

    public interface IEpicResource : IEpicResource<Epic, int> { }

    public interface IEpicResource<TModel, TKey> :
        IListable<TModel, TKey>,
        ICreateable<TModel, TModel, TKey>,
        IGettable<TModel, TKey>,
        IUpdateable<TModel, TModel, TKey>,
        IDeletable<TKey> where TModel : ClubHouseModel<TKey>
    {
    }
}
