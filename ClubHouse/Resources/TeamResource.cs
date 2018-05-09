using ClubHouse.Models;
using System.Net.Http;

namespace ClubHouse.Resources
{
    internal class TeamResource : Resource<Team, int>, ITeamResource
    {
        internal TeamResource(HttpClient client) : base(client)
        {
        }

        protected override string ResourceName => "teams";
    }

    /// <summary>
    /// Access to <see cref="Team"/>'s in the organization.
    /// </summary>
    public interface ITeamResource :
        IListable<Team, int>,
        IGettable<Team, int>
    {
    }
}
