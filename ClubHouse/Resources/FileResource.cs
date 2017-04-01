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

    public interface IFileResource :
        IGettable<File, int>,
        IListable<File, int>,
        IUpdateable<File, File, int>,
        IDeletable<int>
    { }
}
