using ClubHouse.Resources;
using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ClubHouse.Test")]
namespace ClubHouse
{

    public class ClubHouseClient : IDisposable
    {
        const string EndPoint = "https://api.clubhouse.io/api/v1/";
        internal ClubHouseHttpClient HttpClient;

        public ClubHouseClient(string apiToken)
        {
            if (string.IsNullOrEmpty(apiToken))
                throw new ArgumentNullException(nameof(apiToken));

            HttpClient = new ClubHouseHttpClient(apiToken)
            {
                BaseAddress = new Uri(EndPoint)
            };

            Projects = new ProjectResource(HttpClient);
            Epics = new EpicResource(HttpClient);
            Users = new UserResource(HttpClient);
            Labels = new LabelResource(HttpClient);

        }

        public IProjectResource Projects { get; }
        public IEpicResource Epics { get; }
        public IUserResource Users { get; }
        public ILabelResource Labels { get; }

        public void Dispose()
        {
            ((IDisposable)HttpClient).Dispose();
        }
    }
}
