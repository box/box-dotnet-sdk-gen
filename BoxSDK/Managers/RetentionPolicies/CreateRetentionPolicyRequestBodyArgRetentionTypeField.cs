using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateRetentionPolicyRequestBodyArgRetentionTypeField>))]
    public enum CreateRetentionPolicyRequestBodyArgRetentionTypeField {
        [Description("modifiable")]
        Modifiable,
        [Description("non-modifiable")]
        NonModifiable
    }
}