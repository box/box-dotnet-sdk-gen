using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetLegalHoldPoliciesQueryParamsArg {
        public string PolicyName { get; }

        public string Fields { get; }

        public string Marker { get; }

        public int? Limit { get; }

        public GetLegalHoldPoliciesQueryParamsArg(string policyName, string fields, string marker, int? limit) {
            PolicyName = policyName;
            Fields = fields;
            Marker = marker;
            Limit = limit;
        }
    }
}