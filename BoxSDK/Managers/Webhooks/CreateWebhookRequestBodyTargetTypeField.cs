using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateWebhookRequestBodyTargetTypeField>))]
    public enum CreateWebhookRequestBodyTargetTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}