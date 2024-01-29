using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateTaskRequestBody {
        /// <summary>
        /// The file to attach the task to.
        /// </summary>
        [JsonPropertyName("item")]
        public CreateTaskRequestBodyItemField Item { get; set; }

        /// <summary>
        /// The action the task assignee will be prompted to do. Must be
        /// 
        /// * `review` defines an approval task that can be approved or
        /// rejected
        /// * `complete` defines a general task which can be completed
        /// </summary>
        [JsonPropertyName("action")]
        public CreateTaskRequestBodyActionField? Action { get; set; } = default;

        /// <summary>
        /// An optional message to include with the task.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        /// <summary>
        /// Defines when the task is due. Defaults to `null` if not
        /// provided.
        /// </summary>
        [JsonPropertyName("due_at")]
        public System.DateTimeOffset? DueAt { get; set; } = default;

        /// <summary>
        /// Defines which assignees need to complete this task before the task
        /// is considered completed.
        /// 
        /// * `all_assignees` (default) requires all assignees to review or
        /// approve the the task in order for it to be considered completed.
        /// * `any_assignee` accepts any one assignee to review or
        /// approve the the task in order for it to be considered completed.
        /// </summary>
        [JsonPropertyName("completion_rule")]
        public CreateTaskRequestBodyCompletionRuleField? CompletionRule { get; set; } = default;

        public CreateTaskRequestBody(CreateTaskRequestBodyItemField item) {
            Item = item;
        }
    }
}