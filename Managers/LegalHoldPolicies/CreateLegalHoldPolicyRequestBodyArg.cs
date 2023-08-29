using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateLegalHoldPolicyRequestBodyArg {
        /// <summary>
        /// The name of the policy.
        /// </summary>
        [JsonPropertyName("policy_name")]
        public string PolicyName { get; set; }

        /// <summary>
        /// A description for the policy.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// The filter start date.
        /// 
        /// When this policy is applied using a `custodian` legal
        /// hold assignments, it will only apply to file versions
        /// created or uploaded inside of the
        /// date range. Other assignment types, such as folders and
        /// files, will ignore the date filter.
        /// 
        /// Required if `is_ongoing` is set to `false`.
        /// </summary>
        [JsonPropertyName("filter_started_at")]
        public string? FilterStartedAt { get; set; } = default;

        /// <summary>
        /// The filter end date.
        /// 
        /// When this policy is applied using a `custodian` legal
        /// hold assignments, it will only apply to file versions
        /// created or uploaded inside of the
        /// date range. Other assignment types, such as folders and
        /// files, will ignore the date filter.
        /// 
        /// Required if `is_ongoing` is set to `false`.
        /// </summary>
        [JsonPropertyName("filter_ended_at")]
        public string? FilterEndedAt { get; set; } = default;

        /// <summary>
        /// Whether new assignments under this policy should
        /// continue applying to files even after initialization.
        /// 
        /// When this policy is applied using a legal hold assignment,
        /// it will continue applying the policy to any new file versions
        /// even after it has been applied.
        /// 
        /// For example, if a legal hold assignment is placed on a user
        /// today, and that user uploads a file tomorrow, that file will
        /// get held. This will continue until the policy is retired.
        /// 
        /// Required if no filter dates are set.
        /// </summary>
        [JsonPropertyName("is_ongoing")]
        public bool? IsOngoing { get; set; } = default;

        public CreateLegalHoldPolicyRequestBodyArg(string policyName) {
            PolicyName = policyName;
        }
    }
}