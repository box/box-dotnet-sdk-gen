using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    [JsonConverter(typeof(StringEnumConverter<SearchForContentQueryParamsDirectionField>))]
    public enum SearchForContentQueryParamsDirectionField {
        [Description("DESC")]
        Desc,
        [Description("ASC")]
        Asc
    }
}