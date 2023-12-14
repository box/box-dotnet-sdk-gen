using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetSearchQueryParamsDirectionField>))]
    public enum GetSearchQueryParamsDirectionField {
        [Description("DESC")]
        Desc,
        [Description("ASC")]
        Asc
    }
}