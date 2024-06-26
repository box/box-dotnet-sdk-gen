using Box.Sdk.Gen;
using Serialization.Json;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
            };
            _options.Converters.Add(new DateOnlyJsonConverter());
        }

        public static SerializedData Serialize(object obj) => new SerializedData(obj);


        public static T Deserialize<T>(SerializedData obj)
        {
            return JsonSerializer.Deserialize<T>(obj.AsJson(), _options);
        }

        public static string SdToJson(SerializedData obj) => JsonSerializer.Serialize(obj.Data, _options);
    }

    //Remove when migrated to .NET 7
    internal sealed class DateOnlyJsonConverter : JsonConverter<DateOnly>
    {
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateOnly.FromDateTime(reader.GetDateTime());
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            var isoDate = value.ToString("O");
            writer.WriteStringValue(isoDate);
        }
    }

    class StringEnumConverter<T> : JsonConverter<StringEnum<T>> where T : struct, Enum
    {
        public override StringEnum<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            var stringValue = document.RootElement.ToString();
            var enumType = typeof(T);
            var enumFields = enumType.GetFields();

            foreach (var field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (attribute?.Description.Equals(stringValue, StringComparison.OrdinalIgnoreCase) == true)
                {
                    return new StringEnum<T>((T)field.GetValue(null));
                }
            }

            return new StringEnum<T>(stringValue);
        }

        public override void Write(Utf8JsonWriter writer, StringEnum<T> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.StringValue, options);
            return;
        }
    }

    class StringEnumListConverter<T> : JsonConverter<IReadOnlyList<StringEnum<T>>> where T : struct, Enum
    {
        private readonly JsonConverter<StringEnum<T>> _singleConverter;

        public StringEnumListConverter()
        {
            _singleConverter = new StringEnumConverter<T>();
        }

        public override IReadOnlyList<StringEnum<T>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var list = new List<StringEnum<T>>();

            if (reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    return list;

                if (reader.TokenType == JsonTokenType.String)
                {
                    var element = _singleConverter.Read(ref reader, typeof(StringEnum<T>), options);
                    list.Add(element);
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, IReadOnlyList<StringEnum<T>> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            foreach (var item in value)
            {
                _singleConverter.Write(writer, item, options);
            }

            writer.WriteEndArray();
        }
    }

    class StringEnumNestedListConverter<T> : JsonConverter<IReadOnlyList<IReadOnlyList<StringEnum<T>>>> where T : struct, Enum
    {
        private readonly JsonConverter<IReadOnlyList<StringEnum<T>>> _innerListConverter;

        public StringEnumNestedListConverter()
        {
            _innerListConverter = new StringEnumListConverter<T>();
        }

        public override IReadOnlyList<IReadOnlyList<StringEnum<T>>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var nestedList = new List<IReadOnlyList<StringEnum<T>>>();

            if (reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    return nestedList;

                if (reader.TokenType == JsonTokenType.StartArray)
                {
                    var innerList = _innerListConverter.Read(ref reader, typeof(IReadOnlyList<StringEnum<T>>), options);
                    nestedList.Add(innerList);
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, IReadOnlyList<IReadOnlyList<StringEnum<T>>> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            foreach (var innerList in value)
            {
                _innerListConverter.Write(writer, innerList, options);
            }

            writer.WriteEndArray();
        }
    }
}
