using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RoleVariableTypeField>))]
    public enum RoleVariableTypeField {
        [Description("variable")]
        Variable
    }
}