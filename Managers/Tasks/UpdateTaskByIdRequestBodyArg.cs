using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTaskByIdRequestBodyArg {
        [JsonPropertyName("action")]
        public UpdateTaskByIdRequestBodyArgActionField Action { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("due_at")]
        public string DueAt { get; }

        [JsonPropertyName("completion_rule")]
        public UpdateTaskByIdRequestBodyArgCompletionRuleField CompletionRule { get; }

        public UpdateTaskByIdRequestBodyArg(UpdateTaskByIdRequestBodyArgActionField action, string message, string dueAt, UpdateTaskByIdRequestBodyArgCompletionRuleField completionRule) {
            Action = action;
            Message = message;
            DueAt = dueAt;
            CompletionRule = completionRule;
        }
    }
}