using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClubHouse.Models;
using Newtonsoft.Json;

namespace ClubHouse.Resources
{
    internal class ProjectResource : Resource<Project, int>, IProjectResource
    {
        protected override string ResourceName => "projects";

        internal ProjectResource(ClubHouseHttpClient client) : base(client)
        {
        }


        public virtual async Task<IList<Story>> ListStories(int id)
        {
            var result = await _client.GetAsync($"{ResourceUrl(id)}/stories");
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IList<Story>>(content, DefaultSettings());
        }

    }

    public interface IProjectResource : IProjectResource<Project, int>
    {
        Task<IList<Story>> ListStories(int id);
    }

    public interface IProjectResource<TModel, TKey> :
        IListable<TModel, TKey>,
        IGettable<TModel, TKey>,
        IUpdateable<TModel, TModel, TKey>,
        ICreateable<TModel, TModel, TKey>,
        IDeletable<TKey> where TModel : ClubHouseModel<TKey>
    {
    }
}
