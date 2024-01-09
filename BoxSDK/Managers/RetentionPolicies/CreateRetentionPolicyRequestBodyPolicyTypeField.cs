using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateRetentionPolicyRequestBodyPolicyTypeField>))]
    public enum CreateRetentionPolicyRequestBodyPolicyTypeField {
        [Description("finite")]
        Finite,
        [Description("indefinite")]
        Indefinite
    }
}