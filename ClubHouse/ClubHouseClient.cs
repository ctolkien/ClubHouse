using ClubHouse.Resources;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ClubHouse.Test")]
namespace ClubHouse
{
    /// <summary>
    /// Provices a wrapper over the Clubhouse.io API.
    /// </summary>
    public class ClubHouseClient : IDisposable
    {
        const string EndPoint = "https://api.clubhouse.io/api/v1/";
        internal HttpClient HttpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubHouseClient"/> class.
        /// </summary>
        /// <param name="apiToken">
        /// The API token used to access the Clubhouse API.
        /// All actions will be performed on behalf of the user that generated this token.
        /// </param>
        public ClubHouseClient(string apiToken) : this(apiToken, new ClubHouseHttpMessageHandler(apiToken))
        {
        }

        //This constructure is used for testing only - allows you to inject your own message handler
        internal ClubHouseClient(string apiToken, HttpMessageHandler messageHandler)
        {
            if (string.IsNullOrEmpty(apiToken))
            {
                throw new ArgumentNullException(nameof(apiToken));
            }

            HttpClient = new ClubHouseHttpClient(apiToken, EndPoint, messageHandler);

            Epics = new EpicResource(HttpClient);
            Files = new FileResource(HttpClient);
            Labels = new LabelResource(HttpClient);
            LinkedFiles = new LinkedFileResource(HttpClient);
            Projects = new ProjectResource(HttpClient);
            StoryLinks = new StoryLinkResource(HttpClient);
            Stories = new StoryResource(HttpClient);
            Users = new UserResource(HttpClient);
            Workflows = new WorkflowResource(HttpClient);
        }

        /// <summary>
        /// Access Clubhouse <see cref="Models.Project">Projects</see>.
        /// </summary>
        public IProjectResource Projects { get; }
        /// <summary>
        /// Access Clubhouse <see cref="Models.Epic">Epics</see>.
        /// </summary>
        public IEpicResource Epics { get; }
        /// <summary>
        /// Access Clubhouse <see cref="Models.User">Users</see>.
        /// </summary>
        public IUserResource Users { get; }
        /// <summary>
        /// Access Clubhouse <see cref="Models.Label">Labels</see>.
        /// </summary>
        public ILabelResource Labels { get; }
        /// <summary>
        /// Access to Clubhouse <see cref="Models.StoryLink">Story Links</see>.
        /// This is the relationship between multiple stories. For example 'X is blocked by Y'
        /// </summary>
        public IStoryLinkResource StoryLinks { get; }
        /// <summary>
        /// Access to Clubhouse <see cref="Models.File">Files</see>.
        /// </summary>
        public IFileResource Files { get; }
        /// <summary>
        /// Access to Clubhouse <see cref="Models.LinkedFile">Linked Files</see>.
        /// This are hosted or refered to on a 3rd party external service from Clubhouse.
        /// </summary>
        public ILinkedFileResource LinkedFiles { get; }
        /// <summary>
        /// Access to Clubhouse <see cref="Models.Workflow">Workflows</see>.
        /// </summary>
        public IWorkflowResource Workflows { get; }
        /// <summary>
        /// Gets access to Clubhouse <see cref="Models.Story">Stories</see>
        /// </summary>
        public IStoryResource Stories { get; }

        public void Dispose()
        {
            ((IDisposable)HttpClient).Dispose();
        }
    }
}
