using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<ApplyMetadataCascadePolicyRequestBodyConflictResolutionField>))]
    public enum ApplyMetadataCascadePolicyRequestBodyConflictResolutionField {
        [Description("none")]
        None,
        [Description("overwrite")]
        Overwrite
    }
}