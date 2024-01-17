using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StoragePolicyAssignmentTypeField>))]
    public enum StoragePolicyAssignmentTypeField {
        [Description("storage_policy_assignment")]
        StoragePolicyAssignment
    }
}