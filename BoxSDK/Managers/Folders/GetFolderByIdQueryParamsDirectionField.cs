using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetFolderByIdQueryParamsDirectionField>))]
    public enum GetFolderByIdQueryParamsDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}