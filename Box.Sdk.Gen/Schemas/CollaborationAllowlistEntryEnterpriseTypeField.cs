using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistEntryEnterpriseTypeField>))]
    public enum CollaborationAllowlistEntryEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}