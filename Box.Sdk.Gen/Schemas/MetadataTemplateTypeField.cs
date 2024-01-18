using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataTemplateTypeField>))]
    public enum MetadataTemplateTypeField {
        [Description("metadata_template")]
        MetadataTemplate
    }
}