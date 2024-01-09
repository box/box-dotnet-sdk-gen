using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(MetadataFilterFiltersFieldConverter))]
    public class MetadataFilterFiltersField : OneOf<Dictionary<string, string>, Dictionary<string, double>, Dictionary<string, IReadOnlyList<string>>, Dictionary<string, MetadataFieldFilterFloatRangeValue>, Dictionary<string, MetadataFieldFilterDateRangeValue>> {
        public Dictionary<string, string>? MetadataFieldFilterString => _val0;
        
        public Dictionary<string, double>? MetadataFieldFilterFloat => _val1;
        
        public Dictionary<string, IReadOnlyList<string>>? MetadataFieldFilterMultiSelect => _val2;
        
        public Dictionary<string, MetadataFieldFilterFloatRangeValue>? MetadataFieldFilterFloatRange => _val3;
        
        public Dictionary<string, MetadataFieldFilterDateRangeValue>? MetadataFieldFilterDateRange => _val4;
        
        public MetadataFilterFiltersField(Dictionary<string, string> value) : base(value) {}
        
        public MetadataFilterFiltersField(Dictionary<string, double> value) : base(value) {}
        
        public MetadataFilterFiltersField(Dictionary<string, IReadOnlyList<string>> value) : base(value) {}
        
        public MetadataFilterFiltersField(Dictionary<string, MetadataFieldFilterFloatRangeValue> value) : base(value) {}
        
        public MetadataFilterFiltersField(Dictionary<string, MetadataFieldFilterDateRangeValue> value) : base(value) {}
        
        public static implicit operator MetadataFilterFiltersField(Dictionary<string, string> value) => new MetadataFilterFiltersField(value);
        
        public static implicit operator MetadataFilterFiltersField(Dictionary<string, double> value) => new MetadataFilterFiltersField(value);
        
        public static implicit operator MetadataFilterFiltersField(Dictionary<string, IReadOnlyList<string>> value) => new MetadataFilterFiltersField(value);
        
        public static implicit operator MetadataFilterFiltersField(Dictionary<string, MetadataFieldFilterFloatRangeValue> value) => new MetadataFilterFiltersField(value);
        
        public static implicit operator MetadataFilterFiltersField(Dictionary<string, MetadataFieldFilterDateRangeValue> value) => new MetadataFilterFiltersField(value);
        
        class MetadataFilterFiltersFieldConverter : JsonConverter<MetadataFilterFiltersField> {
            public override MetadataFilterFiltersField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, MetadataFilterFiltersField? value, JsonSerializerOptions options) {
            }

        }

    }
}