using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyFieldTypeField>))]
    public enum CreateStoragePolicyAssignmentRequestBodyArgStoragePolicyFieldTypeField {
        [Description("storage_policy")]
        StoragePolicy
    }
}