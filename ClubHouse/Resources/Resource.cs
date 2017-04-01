using ClubHouse.Models;
using ClubHouse.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    internal abstract class Resource<TModel, TKey> where TModel: ClubHouseModel<TKey>
    {
        protected readonly ClubHouseHttpClient _client;
        protected abstract string ResourceName { get; }

        protected Func<JsonSerializerSettings> DefaultUpdateSettings = () => new UpdateSerializerSettings();
        protected Func<JsonSerializerSettings> DefaultCreateSettings = () => new CreateSerializerSettings();
        protected Func<JsonSerializerSettings> DefaultSettings = () => new DefaultSerializerSettings();

        internal Resource(ClubHouseHttpClient client)
        {
            _client = client;
        }

        protected virtual string ResourceUrl(TKey id)
        {
            return $"{ResourceName}/{id}";
        }

        public virtual async Task<IList<TModel>> List()
        {
            var result = await _client.GetAsync(ResourceName);
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IList<TModel>>(content, DefaultSettings());
        }

        public virtual async Task<TModel> Create<TInput>(TInput model) where TInput : ClubHouseModel<TKey>
        {
            var serialized = JsonConvert.SerializeObject(model, DefaultCreateSettings());
            var httpConent = new System.Net.Http.StringContent(serialized);
            var result = await _client.PostAsync(ResourceName, httpConent);

            return JsonConvert.DeserializeObject<TModel>(await result.Content.ReadAsStringAsync(), DefaultSettings());
        }

        public virtual async Task<TModel> Get(TKey id)
        {
            var result = await _client.GetAsync(ResourceUrl(id));
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TModel>(content, DefaultSettings());
        }

        //public virtual async Task<T> Update(T model)
        //{
        //    return await Update<T>(model);
        //}

        public virtual async Task<TModel> Update<TInput>(TInput model) where TInput: ClubHouseModel<TKey>
        {
            var serialized = JsonConvert.SerializeObject(model, DefaultUpdateSettings());
            var httpConent = new System.Net.Http.StringContent(serialized);
            var result = await _client.PutAsync(ResourceUrl(model.Id), httpConent);

            return JsonConvert.DeserializeObject<TModel>(await result.Content.ReadAsStringAsync(), DefaultSettings());
        }

        public virtual async Task Delete(TKey id)
        {
            await _client.DeleteAsync(ResourceUrl(id));
        }

    }


}
