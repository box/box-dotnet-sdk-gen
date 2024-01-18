using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationTypeField>))]
    public enum CollaborationTypeField {
        [Description("collaboration")]
        Collaboration
    }
}