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

        protected static JsonSerializerSettings DefaultUpdateSettings = new UpdateSerializerSettings();
        protected static JsonSerializerSettings DefaultCreateSettings = new CreateSerializerSettings();
        protected static JsonSerializerSettings DefaultSettings = new DefaultSerializerSettings();

        internal Resource(HttpClient client)
        {
            _client = client;
        }

        protected virtual string ResourceUrl()
        {
            return $"{ResourceName}";
        }
        protected virtual string ResourceUrl(TKey id)
        {
            return $"{ResourceName}/{id}";
        }
        protected virtual string ResourceUrl(bool bulk)
        {
            return $"{ResourceName}/bulk";
        }

        public virtual async Task<IReadOnlyList<TModel>> List()
        {
            var result = await _client.GetAsync(ResourceUrl());
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IReadOnlyList<TModel>>(content, DefaultSettings);
        }
        public virtual async Task<TModel> Get(TKey id)
        {
            var result = await _client.GetAsync(ResourceUrl(id));
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TModel>(content, DefaultSettings);
        }

        public virtual async Task<TModel> Create(TModel model)
        {
            return await Create<TModel>(model);
        }

        public virtual async Task<TModel> Create<TInput>(TInput model) where TInput : ClubHouseModel<TKey>
        {
            return await Create<TModel>(model, ResourceUrl());
        }
        public virtual async Task<TOutput> Create<TInput, TOutput>(IEnumerable<TInput> model) where TInput : ClubHouseModel<TKey>
        {
            var collectionWrapped = new Dictionary<string, IEnumerable<TInput>>
            {
                { ResourceName, model }
            };

            return await Create<TOutput>(collectionWrapped, ResourceUrl(bulk: true));
        }

        protected async Task<TOutput> Create<TOutput>(object model, string resourceUrl)
        {
            var serialized = JsonConvert.SerializeObject(model, DefaultCreateSettings);
            var httpConent = new System.Net.Http.StringContent(serialized);
            var result = await _client.PostAsync(resourceUrl, httpConent);
            return JsonConvert.DeserializeObject<TOutput>(await result.Content.ReadAsStringAsync(), DefaultSettings);
        }


        public virtual async Task<TModel> Update(TModel model)
        {
            return await Update<TModel>(model);
        }

        public virtual async Task<TModel> Update<TInput>(TInput model) where TInput: ClubHouseModel<TKey>
        {
            return await Update<TModel>(model, ResourceUrl(model.Id));
        }

        public virtual async Task<TOutput> Update<TInput, TOutput>(IEnumerable<TInput> model) where TInput : ClubHouseModel<TKey>
        {
            return await Update<TOutput>(model, ResourceUrl(bulk: true));
        }

        protected async Task<TOutput> Update<TOutput>(object model, string resourceUrl)
        {
            var serialized = JsonConvert.SerializeObject(model, DefaultUpdateSettings);
            var httpConent = new System.Net.Http.StringContent(serialized);

            var result = await _client.PutAsync(resourceUrl, httpConent);

            return JsonConvert.DeserializeObject<TOutput>(await result.Content.ReadAsStringAsync(), DefaultSettings);
        }

        public virtual async Task Delete(TKey id)
        {
            await _client.DeleteAsync(ResourceUrl(id));
        }

    }
}
