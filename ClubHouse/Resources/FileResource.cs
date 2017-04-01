using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class FileResource : Resource<File, int>, IFileResource
    {
        protected override string ResourceName => "files";
        internal FileResource(ClubHouseHttpClient client) : base(client)
        {
        }

    }

    public interface IFileResource : IFileResource<File, int>
    {
    }
    public interface IFileResource<TModel, TKey> :
        IGettable<TModel, TKey>,
        IListable<TModel, TKey>,
        IUpdateable<TModel, TModel, TKey>,
        IDeletable<TKey> where TModel : ClubHouseModel<TKey>
    { }
}
