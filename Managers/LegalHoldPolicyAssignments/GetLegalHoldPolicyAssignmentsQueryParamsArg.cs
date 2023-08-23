using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetLegalHoldPolicyAssignmentsQueryParamsArg {
        public string PolicyId { get; }

        public GetLegalHoldPolicyAssignmentsQueryParamsArgAssignToTypeField AssignToType { get; }

        public string AssignToId { get; }

        public string Marker { get; }

        public long? Limit { get; }

        public string Fields { get; }

        public GetLegalHoldPolicyAssignmentsQueryParamsArg(string policyId, GetLegalHoldPolicyAssignmentsQueryParamsArgAssignToTypeField assignToType, string assignToId, string marker, long? limit, string fields) {
            PolicyId = policyId;
            AssignToType = assignToType;
            AssignToId = assignToId;
            Marker = marker;
            Limit = limit;
            Fields = fields;
        }
    }
}