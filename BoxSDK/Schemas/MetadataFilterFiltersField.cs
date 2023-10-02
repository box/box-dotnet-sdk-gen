using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(MetadataFilterFiltersFieldConverter))]
    public class MetadataFilterFiltersField : OneOf<MetadataFieldFilterString, MetadataFieldFilterFloat, MetadataFieldFilterMultiSelect, MetadataFieldFilterFloatRange, MetadataFieldFilterDateRange> {
        public MetadataFieldFilterString? MetadataFieldFilterString => _val0;
        
        public MetadataFieldFilterFloat? MetadataFieldFilterFloat => _val1;
        
        public MetadataFieldFilterMultiSelect? MetadataFieldFilterMultiSelect => _val2;
        
        public MetadataFieldFilterFloatRange? MetadataFieldFilterFloatRange => _val3;
        
        public MetadataFieldFilterDateRange? MetadataFieldFilterDateRange => _val4;
        
        public MetadataFilterFiltersField(MetadataFieldFilterString value) : base(value) {}
        
        public MetadataFilterFiltersField(MetadataFieldFilterFloat value) : base(value) {}
        
        public MetadataFilterFiltersField(MetadataFieldFilterMultiSelect value) : base(value) {}
        
        public MetadataFilterFiltersField(MetadataFieldFilterFloatRange value) : base(value) {}
        
        public MetadataFilterFiltersField(MetadataFieldFilterDateRange value) : base(value) {}
        
        public static implicit operator MetadataFilterFiltersField(MetadataFieldFilterString value) => new MetadataFilterFiltersField(value);
        
        public static implicit operator MetadataFilterFiltersField(MetadataFieldFilterFloat value) => new MetadataFilterFiltersField(value);
        
        public static implicit operator MetadataFilterFiltersField(MetadataFieldFilterMultiSelect value) => new MetadataFilterFiltersField(value);
        
        public static implicit operator MetadataFilterFiltersField(MetadataFieldFilterFloatRange value) => new MetadataFilterFiltersField(value);
        
        public static implicit operator MetadataFilterFiltersField(MetadataFieldFilterDateRange value) => new MetadataFilterFiltersField(value);
        
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