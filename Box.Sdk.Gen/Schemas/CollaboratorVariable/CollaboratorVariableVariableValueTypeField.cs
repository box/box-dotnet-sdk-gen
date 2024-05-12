using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaboratorVariableVariableValueTypeField>))]
    public enum CollaboratorVariableVariableValueTypeField {
        [Description("user")]
        User
    }
}