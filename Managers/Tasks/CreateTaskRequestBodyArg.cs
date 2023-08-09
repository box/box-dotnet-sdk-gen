using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskRequestBodyArg {
        [JsonPropertyName("item")]
        public CreateTaskRequestBodyArgItemField Item { get; }

        [JsonPropertyName("action")]
        public CreateTaskRequestBodyArgActionField Action { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("due_at")]
        public string DueAt { get; }

        [JsonPropertyName("completion_rule")]
        public CreateTaskRequestBodyArgCompletionRuleField CompletionRule { get; }

        public CreateTaskRequestBodyArg(CreateTaskRequestBodyArgItemField item, CreateTaskRequestBodyArgActionField action, string message, string dueAt, CreateTaskRequestBodyArgCompletionRuleField completionRule) {
            Item = item;
            Action = action;
            Message = message;
            DueAt = dueAt;
            CompletionRule = completionRule;
        }
    }
}