using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyMini : RetentionPolicyBase {
        [JsonPropertyName("policy_name")]
        public string PolicyName { get; }

        [JsonPropertyName("retention_length")]
        public string RetentionLength { get; }

        [JsonPropertyName("disposition_action")]
        public RetentionPolicyMiniDispositionActionField DispositionAction { get; }

        public RetentionPolicyMini(string id, RetentionPolicyBaseTypeField type, string policyName, string retentionLength, RetentionPolicyMiniDispositionActionField dispositionAction) : base(id, type) {
            PolicyName = policyName;
            RetentionLength = retentionLength;
            DispositionAction = dispositionAction;
        }
    }
}