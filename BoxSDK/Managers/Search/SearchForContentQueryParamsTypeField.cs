using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<SearchForContentQueryParamsTypeField>))]
    public enum SearchForContentQueryParamsTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder,
        [Description("web_link")]
        WebLink
    }
}