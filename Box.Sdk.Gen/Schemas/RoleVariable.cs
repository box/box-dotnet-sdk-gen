using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class RoleVariable {
        /// <summary>
        /// Role object type.
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public RoleVariableTypeField Type { get; set; }

        /// <summary>
        /// The variable type used
        /// by the object.
        /// 
        /// </summary>
        [JsonPropertyName("variable_type")]
        public RoleVariableVariableTypeField VariableType { get; set; }

        [JsonPropertyName("variable_value")]
        public RoleVariableVariableValueField VariableValue { get; set; }

        public RoleVariable(RoleVariableTypeField type, RoleVariableVariableTypeField variableType, RoleVariableVariableValueField variableValue) {
            Type = type;
            VariableType = variableType;
            VariableValue = variableValue;
        }
    }
}