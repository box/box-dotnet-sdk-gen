using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistEntryEnterpriseTypeField>))]
    public enum CollaborationAllowlistEntryEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}