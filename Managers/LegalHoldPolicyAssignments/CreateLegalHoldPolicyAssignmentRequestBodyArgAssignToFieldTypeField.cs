using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToFieldTypeField>))]
    public enum CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToFieldTypeField {
        [Description("file")]
        File,
        [Description("file_version")]
        FileVersion,
        [Description("folder")]
        Folder,
        [Description("user")]
        User
    }
}