using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrStringConverter))]
    public class MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString : OneOf<MetadataFieldFilterDateRange, MetadataFieldFilterFloatRange, IReadOnlyList<string>, double, string> {
        public MetadataFieldFilterDateRange? MetadataFieldFilterDateRange => _val0;
        
        public MetadataFieldFilterFloatRange? MetadataFieldFilterFloatRange => _val1;
        
        public IReadOnlyList<string>? IReadOnlyList<string> => _val2;
        
        public double? DoubleVal => _val3;
        
        public string? StringVal => _val4;
        
        public MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(MetadataFieldFilterDateRange value) : base(value) {}
        
        public MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(MetadataFieldFilterFloatRange value) : base(value) {}
        
        public MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(IReadOnlyList<string> value) : base(value) {}
        
        public MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(double value) : base(value) {}
        
        public MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(string value) : base(value) {}
        
        public static implicit operator MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(MetadataFieldFilterDateRange value) => new MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(value);
        
        public static implicit operator MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(MetadataFieldFilterFloatRange value) => new MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(value);
        
        public static implicit operator MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(IReadOnlyList<string> value) => new MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(value);
        
        public static implicit operator MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(double value) => new MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(value);
        
        public static implicit operator MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(string value) => new MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString(value);
    }
}