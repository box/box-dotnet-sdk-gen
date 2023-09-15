using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistEntryDirectionField>))]
    public enum CollaborationAllowlistEntryDirectionField {
        [Description("inbound")]
        Inbound,
        [Description("outbound")]
        Outbound,
        [Description("both")]
        Both
    }
}