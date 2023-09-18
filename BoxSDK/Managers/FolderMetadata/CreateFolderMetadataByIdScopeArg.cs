using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateFolderMetadataByIdScopeArg>))]
    public enum CreateFolderMetadataByIdScopeArg {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise
    }
}