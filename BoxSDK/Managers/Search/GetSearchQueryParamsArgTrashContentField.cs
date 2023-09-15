using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetSearchQueryParamsArgTrashContentField>))]
    public enum GetSearchQueryParamsArgTrashContentField {
        [Description("non_trashed_only")]
        NonTrashedOnly,
        [Description("trashed_only")]
        TrashedOnly,
        [Description("all_items")]
        AllItems
    }
}