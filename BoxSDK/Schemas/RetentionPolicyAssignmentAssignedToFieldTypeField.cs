using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyAssignmentAssignedToFieldTypeField>))]
    public enum RetentionPolicyAssignmentAssignedToFieldTypeField {
        [Description("folder")]
        Folder,
        [Description("enterprise")]
        Enterprise,
        [Description("metadata_template")]
        MetadataTemplate
    }
}