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
            return reader.Value.ToString().DehumanizeTo(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            object alteredValue = value.ToString()
                .SeparateCamelCase()
                .ToLower();

            serializer.Serialize(writer, alteredValue);
        }
    }
}
