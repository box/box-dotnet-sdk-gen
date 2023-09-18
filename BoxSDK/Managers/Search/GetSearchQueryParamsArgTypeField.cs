using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetSearchQueryParamsArgTypeField>))]
    public enum GetSearchQueryParamsArgTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder,
        [Description("web_link")]
        WebLink
    }
}