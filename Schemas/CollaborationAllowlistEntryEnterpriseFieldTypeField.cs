using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistEntryEnterpriseFieldTypeField>))]
    public enum CollaborationAllowlistEntryEnterpriseFieldTypeField {
        [Description("enterprise")]
        Enterprise
    }
}