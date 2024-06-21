using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateTaskAssignmentRequestBodyAssignToField {
        /// <summary>
        /// The ID of the user to assign to the
        /// task.
        /// 
        /// To specify a user by their email
        /// address use the `login` parameter.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The email address of the user to assign to the task.
        /// To specify a user by their user ID please use the `id` parameter.
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; init; }

        public CreateTaskAssignmentRequestBodyAssignToField() {
            
        }
    }
}