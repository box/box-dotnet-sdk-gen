using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class CompletionRuleVariable {
        /// <summary>
        /// Completion
        /// Rule object type.
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public CompletionRuleVariableTypeField Type { get; set; }

        /// <summary>
        /// Variable type
        /// for the Completion
        /// Rule object.
        /// 
        /// </summary>
        [JsonPropertyName("variable_type")]
        public CompletionRuleVariableVariableTypeField VariableType { get; set; }

        /// <summary>
        /// Variable
        /// values for a completion
        /// rule.
        /// 
        /// </summary>
        [JsonPropertyName("variable_value")]
        public CompletionRuleVariableVariableValueField VariableValue { get; set; }

        public CompletionRuleVariable(CompletionRuleVariableVariableValueField variableValue, CompletionRuleVariableTypeField type = CompletionRuleVariableTypeField.Variable, CompletionRuleVariableVariableTypeField variableType = CompletionRuleVariableVariableTypeField.TaskCompletionRule) {
            Type = type;
            VariableType = variableType;
            VariableValue = variableValue;
        }
    }
}