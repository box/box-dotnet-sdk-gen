using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationAllowlistExemptTargetEnterpriseTypeField>))]
    public enum CollaborationAllowlistExemptTargetEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}