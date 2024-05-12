using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CompletionRuleVariableTypeField>))]
    public enum CompletionRuleVariableTypeField {
        [Description("variable")]
        Variable
    }
}