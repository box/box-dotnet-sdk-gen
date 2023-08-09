using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateLegalHoldPolicyByIdRequestBodyArg {
        [JsonPropertyName("policy_name")]
        public string PolicyName { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("release_notes")]
        public string ReleaseNotes { get; }

        public UpdateLegalHoldPolicyByIdRequestBodyArg(string policyName, string description, string releaseNotes) {
            PolicyName = policyName;
            Description = description;
            ReleaseNotes = releaseNotes;
        }
    }
}