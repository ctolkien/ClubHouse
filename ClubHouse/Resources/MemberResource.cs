using ClubHouse.Models;
using System.Net.Http;

namespace ClubHouse.Resources
{
    internal class MemberResource : Resource<Member, string>, IMemberResource
    {
        internal MemberResource(HttpClient client) : base(client)
        {
        }

        protected override string ResourceName => "members";
    }

    public interface IMemberResource :
        IListable<Member, string>,
        IGettable<Member, string>
    {
    }
}
