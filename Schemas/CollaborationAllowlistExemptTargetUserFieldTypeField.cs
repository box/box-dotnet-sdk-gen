using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistExemptTargetUserFieldTypeField>))]
    public enum CollaborationAllowlistExemptTargetUserFieldTypeField {
        [Description("enterprise")]
        Enterprise
    }
}