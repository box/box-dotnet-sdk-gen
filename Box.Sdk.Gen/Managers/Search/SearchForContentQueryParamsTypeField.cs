using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
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