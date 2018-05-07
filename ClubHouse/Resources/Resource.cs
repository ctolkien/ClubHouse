using ClubHouse.Models;
using ClubHouse.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace ClubHouse.Resources
{
    internal abstract class Resource<TModel, TKey> where TModel: ClubHouseModel<TKey>
    {
        protected readonly HttpClient _client;
        protected abstract string ResourceName { get; }

        protected Resource(HttpClient client)
        {
            _client = client;
        }

        protected virtual string ResourceUrl() => ResourceName;

        protected virtual string ResourceUrl(TKey id) => $"{ResourceName}/{id}";
        protected virtual string ResourceUrl(bool bulk) => $"{ResourceName}/bulk";

        public virtual async Task<IReadOnlyList<TModel>> List()
        {
            var result = await _client.GetAsync(ResourceUrl()).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<IReadOnlyList<TModel>>(content, SerializationSettings.Default);
        }

        public virtual async Task<TModel> Get(TKey id)
        {
            var result = await _client.GetAsync(ResourceUrl(id)).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

            return JsonConvert.DeserializeObject<TModel>(content, SerializationSettings.Default);
        }

        public virtual Task<TModel> Create(TModel model) => Create<TModel>(model);

        public virtual Task<TModel> Create<TInput>(TInput model) where TInput : ClubHouseModel<TKey> => Create<TModel>(model, ResourceUrl());

        public virtual Task<TOutput> Create<TInput, TOutput>(IEnumerable<TInput> model) where TInput : ClubHouseModel<TKey>
        {
            var collectionWrapped = new Dictionary<string, IEnumerable<TInput>>
            {
                { ResourceName, model }
            };

            return Create<TOutput>(collectionWrapped, ResourceUrl(bulk: true));
        }

        protected async Task<TOutput> Create<TOutput>(object model, string resourceUrl)
        {
            var serialized = JsonConvert.SerializeObject(model, SerializationSettings.Create);
            var httpContent = new StringContent(serialized);
            var result = await _client.PostAsync(resourceUrl, httpContent).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<TOutput>(await result.Content.ReadAsStringAsync().ConfigureAwait(false), SerializationSettings.Default);
        }

        public virtual Task<TModel> Update(TModel model) => Update<TModel>(model);

        public virtual Task<TModel> Update<TInput>(TInput model) where TInput : ClubHouseModel<TKey>
        {
            return Update<TModel>(model, ResourceUrl(model.Id));
        }

        public virtual Task<TOutput> Update<TInput, TOutput>(IEnumerable<TInput> model) where TInput : ClubHouseModel<TKey>
        {
            return Update<TOutput>(model, ResourceUrl(bulk: true));
        }

        protected async Task<TOutput> Update<TOutput>(object model, string resourceUrl)
        {
            var serialized = JsonConvert.SerializeObject(model, SerializationSettings.Update);
            var httpContent = new StringContent(serialized);

            var result = await _client.PutAsync(resourceUrl, httpContent).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<TOutput>(await result.Content.ReadAsStringAsync().ConfigureAwait(false), SerializationSettings.Default);
        }

        public virtual async System.Threading.Tasks.Task Delete(TKey id)
        {
            var result = await _client.DeleteAsync(ResourceUrl(id)).ConfigureAwait(false);

            if (result.StatusCode != System.Net.HttpStatusCode.NoContent)
            {
                //throw exception
            }
        }
    }
}
