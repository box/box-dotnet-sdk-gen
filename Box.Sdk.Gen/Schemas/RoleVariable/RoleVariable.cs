using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class RoleVariable {
        /// <summary>
        /// Role object type.
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<RoleVariableTypeField>))]
        public StringEnum<RoleVariableTypeField> Type { get; }

        /// <summary>
        /// The variable type used
        /// by the object.
        /// 
        /// </summary>
        [JsonPropertyName("variable_type")]
        [JsonConverter(typeof(StringEnumConverter<RoleVariableVariableTypeField>))]
        public StringEnum<RoleVariableVariableTypeField> VariableType { get; }

        [JsonPropertyName("variable_value")]
        [JsonConverter(typeof(StringEnumConverter<RoleVariableVariableValueField>))]
        public StringEnum<RoleVariableVariableValueField> VariableValue { get; }

        public RoleVariable(RoleVariableVariableValueField variableValue, RoleVariableTypeField type = RoleVariableTypeField.Variable, RoleVariableVariableTypeField variableType = RoleVariableVariableTypeField.CollaboratorRole) {
            Type = type;
            VariableType = variableType;
            VariableValue = variableValue;
        }
        
        [JsonConstructorAttribute]
        internal RoleVariable(StringEnum<RoleVariableVariableValueField> variableValue, StringEnum<RoleVariableTypeField> type, StringEnum<RoleVariableVariableTypeField> variableType) {
            Type = RoleVariableTypeField.Variable;
            VariableType = RoleVariableVariableTypeField.CollaboratorRole;
            VariableValue = variableValue;
        }
    }
}