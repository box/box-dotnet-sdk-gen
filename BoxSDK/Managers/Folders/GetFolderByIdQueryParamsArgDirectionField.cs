using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetFolderByIdQueryParamsArgDirectionField>))]
    public enum GetFolderByIdQueryParamsArgDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}