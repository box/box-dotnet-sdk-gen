using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateMetadataCascadePolicyRequestBodyArgScopeField>))]
    public enum CreateMetadataCascadePolicyRequestBodyArgScopeField {
        [Description("global")]
        Global,
        [Description("enterprise")]
        Enterprise
    }
}