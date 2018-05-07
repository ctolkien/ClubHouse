using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection;
using System.Linq;
using ClubHouse.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClubHouse.Serialization
{
    internal class ClubHouseJsonContractResolver<T> : CamelCasePropertyNamesContractResolver where T : Attribute
    {
        public ClubHouseJsonContractResolver()
        {
            NamingStrategy = new SnakeCaseNamingStrategy();
        }

        [DebuggerStepThrough]
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.DeclaringType.IsSubclassOfRawGeneric(typeof(ClubHouseModel<>)))
            {
                // this bit of funky reflection basically checks if the type is ICollect<> and if so
                // if checks to see if it has any items. If it's empty, then it is not serialised
                var typeInfo = property.PropertyType.GetTypeInfo();

                if (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(ICollection<>))
                {
                    property.ShouldSerialize = instance =>
                        {
                            var propertyInstance = instance.GetType().GetRuntimeProperty(member.Name).GetValue(instance);
                            if (propertyInstance == null) return false;
                            if (int.TryParse(propertyInstance
                                .GetType()
                                .GetTypeInfo()
                                .GetDeclaredProperty("Count")
                                .GetValue(propertyInstance)
                                .ToString(), out int countResult))
                            {
                                return countResult > 0;
                            }
                            return false;
                        };
                }

                if (property.AttributeProvider.GetAttributes(typeof(T), true).Count > 0)
                {
                    property.ShouldSerialize = instance => false;
                }
            }
            return property;
        }
    }
}
