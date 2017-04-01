using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection;
using System.Linq;
using ClubHouse.Models;
using System;

namespace ClubHouse.Serialization
{
    internal class ClubHouseJsonContractResolver<T> : CamelCasePropertyNamesContractResolver where T : Attribute
    {
        public ClubHouseJsonContractResolver()
        {
            NamingStrategy = new SnakeCaseNamingStrategy();
        }
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.DeclaringType.IsSubclassOfRawGeneric(typeof(ClubHouseModel<>)))
            {
                if (property.AttributeProvider.GetAttributes(typeof(T), true).Any())
                {
                    property.ShouldSerialize =
                        instance =>
                        {
                            return false;
                        };
                }
            }

            return property;
        }

    }


}
