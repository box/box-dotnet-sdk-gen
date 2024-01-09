using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateRetentionPolicyRequestBodyDispositionActionField>))]
    public enum CreateRetentionPolicyRequestBodyDispositionActionField {
        [Description("permanently_delete")]
        PermanentlyDelete,
        [Description("remove_retention")]
        RemoveRetention
    }
}