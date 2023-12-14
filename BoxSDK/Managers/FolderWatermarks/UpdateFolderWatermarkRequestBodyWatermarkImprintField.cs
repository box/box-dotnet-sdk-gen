using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFolderWatermarkRequestBodyWatermarkImprintField>))]
    public enum UpdateFolderWatermarkRequestBodyWatermarkImprintField {
        [Description("default")]
        Default
    }
}