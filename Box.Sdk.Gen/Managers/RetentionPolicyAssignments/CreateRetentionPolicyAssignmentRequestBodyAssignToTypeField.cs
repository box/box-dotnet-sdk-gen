using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateRetentionPolicyAssignmentRequestBodyAssignToTypeField>))]
    public enum CreateRetentionPolicyAssignmentRequestBodyAssignToTypeField {
        [Description("enterprise")]
        Enterprise,
        [Description("folder")]
        Folder,
        [Description("metadata_template")]
        MetadataTemplate
    }
}