using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataQueryIndexStatusField>))]
    public enum MetadataQueryIndexStatusField {
        [Description("building")]
        Building,
        [Description("active")]
        Active,
        [Description("disabled")]
        Disabled
    }
}