using Unions;
using System.Text.Json.Serialization;
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
        public CollaboratorVariableTypeField Type { get; }

        /// <summary>
        /// Variable type 
        /// for the Collaborator
        /// object.
        /// 
        /// </summary>
        [JsonPropertyName("variable_type")]
        public CollaboratorVariableVariableTypeField VariableType { get; }

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
    }
}