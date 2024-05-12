using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<LegalHoldPolicyMiniTypeField>))]
    public enum LegalHoldPolicyMiniTypeField {
        [Description("legal_hold_policy")]
        LegalHoldPolicy
    }
}