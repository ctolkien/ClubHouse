using ClubHouse.Resources;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ClubHouse.Test")]
namespace ClubHouse
{
    /// <summary>
    /// Provides a wrapper over the Clubhouse.io API.
    /// </summary>
    public class ClubHouseClient
    {
        private const string EndPoint = "https://api.clubhouse.io/api/v2/";
        internal HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubHouseClient"/> class.
        /// </summary>
        /// <param name="apiToken">
        /// The API token used to access the Clubhouse API.
        /// All actions will be performed on behalf of the user that generated this token.
        /// </param>
        public ClubHouseClient(string apiToken) : this(new ClubHouseHttpMessageHandler(() => apiToken))
        {
            if (string.IsNullOrEmpty(apiToken))
            {
                throw new ArgumentNullException(nameof(apiToken));
            }

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClubHouseClient"/> class.
        /// </summary>
        /// <param name="apiToken">
        /// The API token used to access the Clubhouse API.
        /// This overload allows you to supply a Func which can use different API tokens
        /// whilst reusing the same HttpClient
        /// </param>
        public ClubHouseClient(Func<string> apiToken) : this(new ClubHouseHttpMessageHandler(apiToken))
        {
            if (apiToken == null)
            {
                throw new ArgumentNullException(nameof(apiToken));
            }
        }

        //Actual meat of construction is done here. This ctor is also used for testing
        internal ClubHouseClient(HttpMessageHandler messageHandler)
        {
            if (messageHandler == null)
            {
                throw new ArgumentNullException(nameof(messageHandler));
            }

            _httpClient = new ClubHouseHttpClient(EndPoint, messageHandler);

            Epics = new EpicResource(_httpClient);
            Files = new FileResource(_httpClient);
            Labels = new LabelResource(_httpClient);
            LinkedFiles = new LinkedFileResource(_httpClient);
            Projects = new ProjectResource(_httpClient);
            StoryLinks = new StoryLinkResource(_httpClient);
            Stories = new StoryResource(_httpClient);
            Workflows = new WorkflowResource(_httpClient);
            Categories = new CategoryResource(_httpClient);
            Milestones = new MilestoneResource(_httpClient);
            Repositories = new RepositoryResource(_httpClient);
            Teams = new TeamResource(_httpClient);
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
        /// Access to Clubhouse <see cref="Models.Story">Stories</see>
        /// </summary>
        public IStoryResource Stories { get; }

        /// <summary>
        /// Access to Clubhouse <see cref="Models.Category">Categories</see>
        /// </summary>
        public ICategoryResource Categories { get; }

        /// <summary>
        /// Access to Clubhouse <see cref="Models.Milestone">Milestones</see>
        /// </summary>
        public IMilestoneResource Milestones { get; }

        /// <summary>
        /// Access to Clubhouse <see cref="Models.Repository">Repositories</see>
        /// </summary>
        public IRepositoryResource Repositories { get; }

        /// <summary>
        /// Access to Clubhouse <see cref="Models.Team">Teams</see>
        /// </summary>
        public ITeamResource Teams { get; }
    }
}
