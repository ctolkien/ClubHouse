using ClubHouse.Models;
using System.Net.Http;

namespace ClubHouse.Resources
{
    internal class RepositoryResource : Resource<Repository, int>, IRepositoryResource
    {
        internal RepositoryResource(HttpClient client) : base(client)
        {
        }

        protected override string ResourceName => "repositories";
    }

    public interface IRepositoryResource :
        IGettable<Repository, int>,
        IListable<Repository, int>
    {

    }
}
