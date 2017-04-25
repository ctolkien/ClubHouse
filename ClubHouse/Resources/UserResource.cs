using System.Net.Http;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class UserResource : Resource<User, string>, IUserResource
    {
        protected override string ResourceName => "users";
        internal UserResource(HttpClient client) : base(client)
        {
        }
    }

    public interface IUserResource :
        IListable<User, string>,
        IGettable<User, string>
    {
    }
}
