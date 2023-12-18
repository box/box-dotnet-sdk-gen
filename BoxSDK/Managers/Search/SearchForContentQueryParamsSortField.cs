using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<SearchForContentQueryParamsSortField>))]
    public enum SearchForContentQueryParamsSortField {
        [Description("modified_at")]
        ModifiedAt,
        [Description("relevance")]
        Relevance
    }
}