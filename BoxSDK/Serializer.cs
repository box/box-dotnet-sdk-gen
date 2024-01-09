using Json;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serializer
{
    static class SimpleJsonSerializer
    {
        static JsonSerializerOptions _options;

        static SimpleJsonSerializer()
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };
        }

        public static SerializedData Serialize(object obj) => new SerializedData(obj);


        public static T Deserialize<T>(SerializedData obj)
        {
            return JsonSerializer.Deserialize<T>(obj.AsJson(), _options);
        }

        public static string SdToJson(SerializedData obj) => JsonSerializer.Serialize(obj.Data, _options);
    }

    class StringEnumConverter<T> : JsonConverter<T>
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);

            foreach (var field in typeToConvert.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (attribute?.Description == document.RootElement.ToString())
                {
                    return (T)field.GetValue(null);
                }
            }
            throw new Exception("Attribute not found");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var field = value.GetType().GetField(value.ToString());
            var descriptionAttribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
            JsonSerializer.Serialize(writer, descriptionAttribute.Description, options);
            return;
        }
    }
}
