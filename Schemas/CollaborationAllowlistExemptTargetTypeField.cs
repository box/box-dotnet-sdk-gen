using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistExemptTargetTypeField>))]
    public enum CollaborationAllowlistExemptTargetTypeField {
        [Description("collaboration_whitelist")]
        CollaborationWhitelist
    }
}