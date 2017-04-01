using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class WorkflowResource : Resource<Workflow, int>, IWorkflowResource
    {
        protected override string ResourceName => "workflows";
        public WorkflowResource(ClubHouseHttpClient client) : base(client)
        {
        }
    }

    public interface IWorkflowResource: IListable<Workflow, int>
    {

    }
}
