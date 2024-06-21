using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class CompletionRuleVariable {
        /// <summary>
        /// Completion
        /// Rule object type.
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CompletionRuleVariableTypeField>))]
        public StringEnum<CompletionRuleVariableTypeField> Type { get; }

        /// <summary>
        /// Variable type
        /// for the Completion
        /// Rule object.
        /// 
        /// </summary>
        [JsonPropertyName("variable_type")]
        [JsonConverter(typeof(StringEnumConverter<CompletionRuleVariableVariableTypeField>))]
        public StringEnum<CompletionRuleVariableVariableTypeField> VariableType { get; }

        /// <summary>
        /// Variable
        /// values for a completion
        /// rule.
        /// 
        /// </summary>
        [JsonPropertyName("variable_value")]
        [JsonConverter(typeof(StringEnumConverter<CompletionRuleVariableVariableValueField>))]
        public StringEnum<CompletionRuleVariableVariableValueField> VariableValue { get; }

        public CompletionRuleVariable(CompletionRuleVariableVariableValueField variableValue, CompletionRuleVariableTypeField type = CompletionRuleVariableTypeField.Variable, CompletionRuleVariableVariableTypeField variableType = CompletionRuleVariableVariableTypeField.TaskCompletionRule) {
            Type = type;
            VariableType = variableType;
            VariableValue = variableValue;
        }
        
        [JsonConstructorAttribute]
        internal CompletionRuleVariable(StringEnum<CompletionRuleVariableVariableValueField> variableValue, StringEnum<CompletionRuleVariableTypeField> type, StringEnum<CompletionRuleVariableVariableTypeField> variableType) {
            Type = CompletionRuleVariableTypeField.Variable;
            VariableType = CompletionRuleVariableVariableTypeField.TaskCompletionRule;
            VariableValue = variableValue;
        }
    }
}