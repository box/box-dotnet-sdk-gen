using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SearchResultsTypeField>))]
    public enum SearchResultsTypeField {
        [Description("search_results_items")]
        SearchResultsItems
    }
}