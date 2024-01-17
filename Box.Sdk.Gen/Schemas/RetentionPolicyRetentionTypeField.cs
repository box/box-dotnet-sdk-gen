using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyRetentionTypeField>))]
    public enum RetentionPolicyRetentionTypeField {
        [Description("modifiable")]
        Modifiable,
        [Description("non_modifiable")]
        NonModifiable
    }
}