using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SearchResultsWithSharedLinksTypeField>))]
    public enum SearchResultsWithSharedLinksTypeField {
        [Description("search_results_with_shared_links")]
        SearchResultsWithSharedLinks
    }
}