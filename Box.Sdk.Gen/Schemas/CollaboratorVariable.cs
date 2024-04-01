using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class CollaboratorVariable {
        /// <summary>
        /// Collaborator
        /// object type.
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public CollaboratorVariableTypeField Type { get; set; }

        /// <summary>
        /// Variable type 
        /// for the Collaborator
        /// object.
        /// 
        /// </summary>
        [JsonPropertyName("variable_type")]
        public CollaboratorVariableVariableTypeField VariableType { get; set; }

        /// <summary>
        /// A list of user IDs.
        /// </summary>
        [JsonPropertyName("variable_value")]
        public IReadOnlyList<CollaboratorVariableVariableValueField> VariableValue { get; set; }

        public CollaboratorVariable(IReadOnlyList<CollaboratorVariableVariableValueField> variableValue, CollaboratorVariableTypeField type = CollaboratorVariableTypeField.Variable, CollaboratorVariableVariableTypeField variableType = CollaboratorVariableVariableTypeField.UserList) {
            Type = type;
            VariableType = variableType;
            VariableValue = variableValue;
        }
    }
}