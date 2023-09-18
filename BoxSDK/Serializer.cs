using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Reflection;
using System.ComponentModel;

namespace Serializer
{
    static class SimpleJsonConverter
    {
        static JsonSerializerOptions _options;

        static SimpleJsonConverter()
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                NumberHandling = JsonNumberHandling.AllowReadingFromString |
                    JsonNumberHandling.WriteAsString
            };
        }

        public static string Serialize(object obj) => JsonSerializer.Serialize(obj, _options);

        public static T Deserialize<T>(string obj) => JsonSerializer.Deserialize<T>(obj, _options);
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
