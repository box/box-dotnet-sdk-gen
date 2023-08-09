using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFileByIdRequestBodyArgPermissionsFieldCanDownloadField>))]
    public enum UpdateFileByIdRequestBodyArgPermissionsFieldCanDownloadField {
        [Description("open")]
        Open,
        [Description("company")]
        Company
    }
}