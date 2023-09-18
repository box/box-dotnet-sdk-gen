using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetSearchQueryParamsArgDirectionField>))]
    public enum GetSearchQueryParamsArgDirectionField {
        [Description("DESC")]
        Desc,
        [Description("ASC")]
        Asc
    }
}