using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetTrashedItemsQueryParamsDirectionField>))]
    public enum GetTrashedItemsQueryParamsDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}