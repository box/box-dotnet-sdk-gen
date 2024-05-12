using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistEntryTypeField>))]
    public enum CollaborationAllowlistEntryTypeField {
        [Description("collaboration_whitelist_entry")]
        CollaborationWhitelistEntry
    }
}