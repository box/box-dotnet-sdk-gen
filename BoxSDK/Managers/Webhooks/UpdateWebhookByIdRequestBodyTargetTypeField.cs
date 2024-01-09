using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateWebhookByIdRequestBodyTargetTypeField>))]
    public enum UpdateWebhookByIdRequestBodyTargetTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}