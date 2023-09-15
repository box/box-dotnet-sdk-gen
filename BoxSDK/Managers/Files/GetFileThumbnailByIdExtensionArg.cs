using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetFileThumbnailByIdExtensionArg>))]
    public enum GetFileThumbnailByIdExtensionArg {
        [Description("png")]
        Png,
        [Description("jpg")]
        Jpg
    }
}