using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CompletionRuleVariableVariableTypeField>))]
    public enum CompletionRuleVariableVariableTypeField {
        [Description("task_completion_rule")]
        TaskCompletionRule
    }
}