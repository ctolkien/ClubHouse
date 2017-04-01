using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace ClubHouse.Serialization
{

    internal class DefaultSerializerSettings : JsonSerializerSettings
    {
        public DefaultSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };
            NullValueHandling = NullValueHandling.Ignore;
            Converters.Add(new EnumConverter());
        }
    }

    internal class ClubHouseContractResolverSerializerSettings<T> : DefaultSerializerSettings where T: Attribute
    {
        public ClubHouseContractResolverSerializerSettings()
        {
            ContractResolver = new ClubHouseJsonContractResolver<T>();
        }
    }

    internal class CreateSerializerSettings : ClubHouseContractResolverSerializerSettings<HideFromCreateAttribute>
    { }

    internal class UpdateSerializerSettings : ClubHouseContractResolverSerializerSettings<HideFromUpdateAttribute>
    {
    }
}
