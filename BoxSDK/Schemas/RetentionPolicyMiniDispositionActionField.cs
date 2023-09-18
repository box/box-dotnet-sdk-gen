using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyMiniDispositionActionField>))]
    public enum RetentionPolicyMiniDispositionActionField {
        [Description("permanently_delete")]
        PermanentlyDelete,
        [Description("remove_retention")]
        RemoveRetention
    }
}