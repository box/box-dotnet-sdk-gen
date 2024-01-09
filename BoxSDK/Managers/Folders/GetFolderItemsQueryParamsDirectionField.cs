using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetFolderItemsQueryParamsDirectionField>))]
    public enum GetFolderItemsQueryParamsDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}