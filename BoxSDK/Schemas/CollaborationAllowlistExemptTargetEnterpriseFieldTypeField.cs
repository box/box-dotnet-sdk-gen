using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistExemptTargetEnterpriseFieldTypeField>))]
    public enum CollaborationAllowlistExemptTargetEnterpriseFieldTypeField {
        [Description("enterprise")]
        Enterprise
    }
}