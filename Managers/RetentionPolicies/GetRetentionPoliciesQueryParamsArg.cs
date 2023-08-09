using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRetentionPoliciesQueryParamsArg {
        public string PolicyName { get; }

        public GetRetentionPoliciesQueryParamsArgPolicyTypeField PolicyType { get; }

        public string CreatedByUserId { get; }

        public string Fields { get; }

        public int? Limit { get; }

        public string Marker { get; }

        public GetRetentionPoliciesQueryParamsArg(string policyName, GetRetentionPoliciesQueryParamsArgPolicyTypeField policyType, string createdByUserId, string fields, int? limit, string marker) {
            PolicyName = policyName;
            PolicyType = policyType;
            CreatedByUserId = createdByUserId;
            Fields = fields;
            Limit = limit;
            Marker = marker;
        }
    }
}