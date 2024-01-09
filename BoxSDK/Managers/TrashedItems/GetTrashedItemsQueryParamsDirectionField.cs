using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetTrashedItemsQueryParamsDirectionField>))]
    public enum GetTrashedItemsQueryParamsDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}