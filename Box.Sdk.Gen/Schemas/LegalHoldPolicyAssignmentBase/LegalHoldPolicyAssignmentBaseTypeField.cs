using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<LegalHoldPolicyAssignmentBaseTypeField>))]
    public enum LegalHoldPolicyAssignmentBaseTypeField {
        [Description("legal_hold_policy_assignment")]
        LegalHoldPolicyAssignment
    }
}