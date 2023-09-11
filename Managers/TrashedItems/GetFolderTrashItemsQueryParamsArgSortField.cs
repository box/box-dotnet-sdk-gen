using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetFolderTrashItemsQueryParamsArgSortField>))]
    public enum GetFolderTrashItemsQueryParamsArgSortField {
        [Description("name")]
        Name,
        [Description("date")]
        Date,
        [Description("size")]
        Size
    }
}