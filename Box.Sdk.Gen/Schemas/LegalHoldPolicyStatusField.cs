using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<LegalHoldPolicyStatusField>))]
    public enum LegalHoldPolicyStatusField {
        [Description("active")]
        Active,
        [Description("applying")]
        Applying,
        [Description("releasing")]
        Releasing,
        [Description("released")]
        Released
    }
}