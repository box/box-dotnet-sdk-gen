using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateClassificationOnFolderRequestBodyOpField>))]
    public enum UpdateClassificationOnFolderRequestBodyOpField {
        [Description("replace")]
        Replace
    }
}