using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClassificationTemplateFieldsTypeField>))]
    public enum ClassificationTemplateFieldsTypeField {
        [Description("enum")]
        Enum
    }
}