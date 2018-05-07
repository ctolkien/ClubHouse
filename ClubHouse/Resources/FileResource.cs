using System.Net.Http;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class FileResource : Resource<File, int>, IFileResource
    {
        protected override string ResourceName => "files";

        internal FileResource(HttpClient client) : base(client)
        {
        }
    }

    public interface IFileResource :
        IGettable<File, int>,
        IListable<File, int>,
        IUpdateable<File, File, int>,
        ICreateable<File, File, int>,
        IDeletable<int>
    {
    }
}
