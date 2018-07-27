using System;
using Newtonsoft.Json;

namespace GetCryptoPrice.Properties
{
    public class JsonStringToNumberConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            //writer.WriteValue(value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return Convert.ToDouble(reader.Value);
        }
         
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
