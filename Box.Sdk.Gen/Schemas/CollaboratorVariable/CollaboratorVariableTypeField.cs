using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaboratorVariableTypeField>))]
    public enum CollaboratorVariableTypeField {
        [Description("variable")]
        Variable
    }
}