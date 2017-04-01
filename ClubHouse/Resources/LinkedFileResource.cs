using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class LinkedFileResource : Resource<LinkedFile, int>, ILinkedFileResource
    {
        protected override string ResourceName => "linked-files";
        internal LinkedFileResource(ClubHouseHttpClient client) : base(client)
        {
        }


    }

    public interface ILinkedFileResource : ILinkedFileResource<LinkedFile, int>
    {
    }

    public interface ILinkedFileResource<TModel, TKey> :
        IListable<TModel, TKey>,
        ICreateable<TModel, TModel, TKey>,
        IGettable<TModel, TKey>,
        IUpdateable<TModel, TModel, TKey>,
        IDeletable<TKey> where TModel : ClubHouseModel<TKey>
    {
    }

}
