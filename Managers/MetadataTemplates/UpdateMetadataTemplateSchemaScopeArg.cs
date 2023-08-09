using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateMetadataTemplateSchemaScopeArg>))]
    public enum UpdateMetadataTemplateSchemaScopeArg {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise
    }
}