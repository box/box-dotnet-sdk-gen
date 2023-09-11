using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetFolderItemsQueryParamsArgDirectionField>))]
    public enum GetFolderItemsQueryParamsArgDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}