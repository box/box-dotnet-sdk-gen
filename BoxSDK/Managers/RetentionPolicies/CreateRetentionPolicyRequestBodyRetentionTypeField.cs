using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateRetentionPolicyRequestBodyRetentionTypeField>))]
    public enum CreateRetentionPolicyRequestBodyRetentionTypeField {
        [Description("modifiable")]
        Modifiable,
        [Description("non_modifiable")]
        NonModifiable
    }
}