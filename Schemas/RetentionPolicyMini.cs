using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyMini : RetentionPolicyBase {
        /// <summary>
        /// The name given to the retention policy.
        /// </summary>
        [JsonPropertyName("policy_name")]
        public string? PolicyName { get; set; } = default;

        /// <summary>
        /// The length of the retention policy. This value
        /// specifies the duration in days that the retention
        /// policy will be active for after being assigned to
        /// content.  If the policy has a `policy_type` of
        /// `indefinite`, the `retention_length` will also be
        /// `indefinite`.
        /// </summary>
        [JsonPropertyName("retention_length")]
        public string? RetentionLength { get; set; } = default;

        /// <summary>
        /// The disposition action of the retention policy.
        /// This action can be `permanently_delete`, which
        /// will cause the content retained by the policy
        /// to be permanently deleted, or `remove_retention`,
        /// which will lift the retention policy from the content,
        /// allowing it to be deleted by users,
        /// once the retention policy has expired.
        /// </summary>
        [JsonPropertyName("disposition_action")]
        public RetentionPolicyMiniDispositionActionField? DispositionAction { get; set; } = default;

        public RetentionPolicyMini(string id, RetentionPolicyBaseTypeField type) : base(id, type) {
            
        }
    }
}