using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaboratorVariableVariableTypeField>))]
    public enum CollaboratorVariableVariableTypeField {
        [Description("user_list")]
        UserList
    }
}