using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetRetentionPolicyAssignmentsQueryParamsArgTypeField>))]
    public enum GetRetentionPolicyAssignmentsQueryParamsArgTypeField {
        [Description("folder")]
        Folder,
        [Description("enterprise")]
        Enterprise,
        [Description("metadata_template")]
        MetadataTemplate
    }
}