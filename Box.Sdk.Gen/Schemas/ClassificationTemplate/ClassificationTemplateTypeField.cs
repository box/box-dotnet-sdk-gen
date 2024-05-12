using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateTypeField>))]
    public enum ClassificationTemplateTypeField {
        [Description("metadata_template")]
        MetadataTemplate
    }
}