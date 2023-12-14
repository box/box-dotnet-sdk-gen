using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetFileThumbnailByIdExtension>))]
    public enum GetFileThumbnailByIdExtension {
        [Description("png")]
        Png,
        [Description("jpg")]
        Jpg
    }
}