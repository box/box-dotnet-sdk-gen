using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataQueryOrderByDirectionField>))]
    public enum MetadataQueryOrderByDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}