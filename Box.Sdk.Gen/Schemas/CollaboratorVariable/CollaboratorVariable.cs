using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class CollaboratorVariable {
        /// <summary>
        /// Collaborator
        /// object type.
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CollaboratorVariableTypeField>))]
        public StringEnum<CollaboratorVariableTypeField> Type { get; }

        /// <summary>
        /// Variable type 
        /// for the Collaborator
        /// object.
        /// 
        /// </summary>
        [JsonPropertyName("variable_type")]
        [JsonConverter(typeof(StringEnumConverter<CollaboratorVariableVariableTypeField>))]
        public StringEnum<CollaboratorVariableVariableTypeField> VariableType { get; }

        /// <summary>
        /// A list of user IDs.
        /// </summary>
        [JsonPropertyName("variable_value")]
        public IReadOnlyList<CollaboratorVariableVariableValueField> VariableValue { get; }

        public CollaboratorVariable(IReadOnlyList<CollaboratorVariableVariableValueField> variableValue, CollaboratorVariableTypeField type = CollaboratorVariableTypeField.Variable, CollaboratorVariableVariableTypeField variableType = CollaboratorVariableVariableTypeField.UserList) {
            Type = type;
            VariableType = variableType;
            VariableValue = variableValue;
        }
        
        [JsonConstructorAttribute]
        internal CollaboratorVariable(IReadOnlyList<CollaboratorVariableVariableValueField> variableValue, StringEnum<CollaboratorVariableTypeField> type, StringEnum<CollaboratorVariableVariableTypeField> variableType) {
            Type = CollaboratorVariableTypeField.Variable;
            VariableType = CollaboratorVariableVariableTypeField.UserList;
            VariableValue = variableValue;
        }
    }
}