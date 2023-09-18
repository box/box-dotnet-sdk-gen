using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateFolderMetadataByIdScopeArg>))]
    public enum UpdateFolderMetadataByIdScopeArg {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise
    }
}