using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFolderWatermarkRequestBodyArgWatermarkFieldImprintField>))]
    public enum UpdateFolderWatermarkRequestBodyArgWatermarkFieldImprintField {
        [Description("default")]
        Default
    }
}