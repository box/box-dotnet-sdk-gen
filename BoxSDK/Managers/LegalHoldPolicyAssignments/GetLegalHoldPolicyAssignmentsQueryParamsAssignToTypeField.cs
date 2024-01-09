using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetLegalHoldPolicyAssignmentsQueryParamsAssignToTypeField>))]
    public enum GetLegalHoldPolicyAssignmentsQueryParamsAssignToTypeField {
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