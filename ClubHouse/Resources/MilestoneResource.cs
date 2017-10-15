using ClubHouse.Models;
using System.Net.Http;

namespace ClubHouse.Resources
{
    internal class MilestoneResource : Resource<Milestone, int>, IMilestoneResource
    {
        internal MilestoneResource(HttpClient client) : base(client)
        {
        }

        protected override string ResourceName => "milestones";
    }

    public interface IMilestoneResource :
        IListable<Milestone, int>,
        ICreateable<Milestone, Milestone, int>,
        IUpdateable<Milestone, Milestone, int>,
        IGettable<Milestone, int>,
        IDeletable<int>
    {
    }
}
