using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateClassificationTemplateRequestBodyArgScopeField>))]
    public enum CreateClassificationTemplateRequestBodyArgScopeField {
        [Description("enterprise")]
        Enterprise
    }
}