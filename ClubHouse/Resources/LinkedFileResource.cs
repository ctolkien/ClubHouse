using System.Net.Http;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class LinkedFileResource : Resource<LinkedFile, int>, ILinkedFileResource
    {
        protected override string ResourceName => "linked-files";

        internal LinkedFileResource(HttpClient client) : base(client)
        {
        }
    }

    public interface ILinkedFileResource :
        IListable<LinkedFile, int>,
        ICreateable<LinkedFile, LinkedFile, int>,
        IGettable<LinkedFile, int>,
        IUpdateable<LinkedFile, LinkedFile, int>,
        IDeletable<int>
    {
    }
}
