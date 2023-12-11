using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateClassificationOnFileRequestBodyArgOpField>))]
    public enum UpdateClassificationOnFileRequestBodyArgOpField {
        [Description("replace")]
        Replace
    }
}