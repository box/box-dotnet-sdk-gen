using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateLegalHoldPolicyRequestBodyArg {
        [JsonPropertyName("policy_name")]
        public string PolicyName { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("filter_started_at")]
        public string FilterStartedAt { get; }

        [JsonPropertyName("filter_ended_at")]
        public string FilterEndedAt { get; }

        [JsonPropertyName("is_ongoing")]
        public bool? IsOngoing { get; }

        public CreateLegalHoldPolicyRequestBodyArg(string policyName, string description, string filterStartedAt, string filterEndedAt, bool? isOngoing) {
            PolicyName = policyName;
            Description = description;
            FilterStartedAt = filterStartedAt;
            FilterEndedAt = filterEndedAt;
            IsOngoing = isOngoing;
        }
    }
}