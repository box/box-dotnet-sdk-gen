using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateClassificationTemplateRequestBodyArgDisplayNameField>))]
    public enum CreateClassificationTemplateRequestBodyArgDisplayNameField {
        [Description("Classification")]
        Classification
    }
}