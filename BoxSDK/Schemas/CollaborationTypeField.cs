using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationTypeField>))]
    public enum CollaborationTypeField {
        [Description("collaboration")]
        Collaboration
    }
}