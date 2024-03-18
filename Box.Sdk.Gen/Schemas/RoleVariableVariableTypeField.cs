using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RoleVariableVariableTypeField>))]
    public enum RoleVariableVariableTypeField {
        [Description("collaborator_role")]
        CollaboratorRole
    }
}