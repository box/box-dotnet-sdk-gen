using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetSearchQueryParamsContentTypesField>))]
    public enum GetSearchQueryParamsContentTypesField {
        [Description("name")]
        Name,
        [Description("description")]
        Description,
        [Description("file_content")]
        FileContent,
        [Description("comments")]
        Comments,
        [Description("tag")]
        Tag
    }
}