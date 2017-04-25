using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ClubHouse.Models;
using Newtonsoft.Json;

namespace ClubHouse.Resources
{
    internal class ProjectResource : Resource<Project, int>, IProjectResource
    {
        protected override string ResourceName => "projects";

        internal ProjectResource(HttpClient client) : base(client)
        {
        }

        public async Task<IReadOnlyList<Story>> ListStories(int id)
        {
            var result = await _client.GetAsync($"{ResourceUrl(id)}/stories");
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IReadOnlyList<Story>>(content, DefaultSettings);
        }
    }

    public interface IProjectResource :
        IListable<Project, int>,
        IGettable<Project, int>,
        IUpdateable<Project, Project, int>,
        ICreateable<Project, Project, int>,
        IDeletable<int>
    {
        Task<IReadOnlyList<Story>> ListStories(int id);
    }
}
