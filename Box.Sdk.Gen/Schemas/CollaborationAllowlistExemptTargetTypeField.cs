using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistExemptTargetTypeField>))]
    public enum CollaborationAllowlistExemptTargetTypeField {
        [Description("collaboration_whitelist_exempt_target")]
        CollaborationWhitelistExemptTarget
    }
}