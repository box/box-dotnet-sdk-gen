using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UploadPartsOrderDirectionField>))]
    public enum UploadPartsOrderDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}