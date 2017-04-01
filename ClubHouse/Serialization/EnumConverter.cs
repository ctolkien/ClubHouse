using Newtonsoft.Json.Converters;
using System;
using Newtonsoft.Json;
using Humanizer;

namespace ClubHouse.Serialization
{
    internal class EnumConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            //Todo: make this more resiliant
            return reader.Value.ToString().DehumanizeTo(objectType);

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            //Todo: make this more resiliant
            object alteredValue = value.ToString()
                .SeparateCamelCase()
                .ToLower()
                .Trim();

            serializer.Serialize(writer, alteredValue);

        }
    }
}
