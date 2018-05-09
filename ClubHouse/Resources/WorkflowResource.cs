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

    /// <summary>
    /// Access to <see cref="Workflow"/>'s in the organization.
    /// </summary>
    public interface IWorkflowResource: IListable<Workflow, int>
    {
    }
}
