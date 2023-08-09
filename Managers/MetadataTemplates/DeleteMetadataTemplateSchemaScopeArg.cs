using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<DeleteMetadataTemplateSchemaScopeArg>))]
    public enum DeleteMetadataTemplateSchemaScopeArg {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise
    }
}