using ClubHouse.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    internal abstract class Resource<T, TModel> where T: ClubHouseModel<TModel>
    {
        protected readonly ClubHouseHttpClient _client;
        protected abstract string ResourceName { get; }

        internal Resource(ClubHouseHttpClient client)
        {
            _client = client;

            JsonConvert.DefaultSettings = () =>
            {
                var settings = new JsonSerializerSettings
                {
                    ContractResolver = new ClubHouseJsonContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                };
                settings.Converters.Add(new EnumConverter());
                return settings;

            };
        }

        protected virtual string ResourceUrl(TModel id)
        {
            return $"{ResourceName}/{id}";
        }

        public virtual async Task<IList<T>> List()
        {
            var result = await _client.GetAsync(ResourceName);
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<IList<T>>(content);
        }

        public virtual async Task<T> Create(T model)
        {
            var serialized = JsonConvert.SerializeObject(model);
            var httpConent = new System.Net.Http.StringContent(serialized);
            var result = await _client.PostAsync(ResourceName, httpConent);

            return JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
        }

        public virtual async Task<T> Get(TModel id)
        {
            var result = await _client.GetAsync(ResourceUrl(id));

            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(content);
        }

        public virtual async Task<T> Update(T model)
        {
            var serialized = JsonConvert.SerializeObject(model);
            var httpConent = new System.Net.Http.StringContent(serialized);
            var result = await _client.PutAsync(ResourceUrl(model.Id), httpConent);

            return JsonConvert.DeserializeObject<T>(await result.Content.ReadAsStringAsync());
        }

        public virtual async Task Delete(TModel id)
        {
            await _client.DeleteAsync(ResourceUrl(id));
        }

    }


}
