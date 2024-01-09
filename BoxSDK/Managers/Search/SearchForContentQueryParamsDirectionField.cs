using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<SearchForContentQueryParamsDirectionField>))]
    public enum SearchForContentQueryParamsDirectionField {
        [Description("DESC")]
        Desc,
        [Description("ASC")]
        Asc
    }
}