using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateMetadataCascadePolicyRequestBodyScopeField>))]
    public enum CreateMetadataCascadePolicyRequestBodyScopeField {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise
    }
}