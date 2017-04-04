using ClubHouse.Resources;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ClubHouse.Test")]
namespace ClubHouse
{

    public class ClubHouseClient : IDisposable
    {
        const string EndPoint = "https://api.clubhouse.io/api/v1/";
        internal ClubHouseHttpClient HttpClient;

        public ClubHouseClient(string apiToken) : this (apiToken, new ClubHouseHttpMessageHandler(apiToken))
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

        public IProjectResource Projects { get; }
        public IEpicResource Epics { get; }
        public IUserResource Users { get; }
        public ILabelResource Labels { get; }
        public IStoryLinkResource StoryLinks { get; }
        public IFileResource Files { get; }
        public ILinkedFileResource LinkedFiles { get;}
        public IWorkflowResource Workflows { get; }
        public IStoryResource Stories { get; }

        public void Dispose()
        {
            ((IDisposable)HttpClient).Dispose();
        }
    }
}
