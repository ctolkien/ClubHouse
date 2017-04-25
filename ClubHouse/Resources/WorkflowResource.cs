using System.Net.Http;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class WorkflowResource : Resource<Workflow, int>, IWorkflowResource
    {
        protected override string ResourceName => "workflows";
        internal WorkflowResource(HttpClient client) : base(client)
        {
        }
    }

    public interface IWorkflowResource: IListable<Workflow, int>
    {
    }
}
