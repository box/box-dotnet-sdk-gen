using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistExemptTargetEnterpriseTypeField>))]
    public enum CollaborationAllowlistExemptTargetEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}