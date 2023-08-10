using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRetentionPolicyAssignmentsQueryParamsArg {
        public GetRetentionPolicyAssignmentsQueryParamsArgTypeField Type { get; }

        public string Fields { get; }

        public string Marker { get; }

        public int? Limit { get; }

        public GetRetentionPolicyAssignmentsQueryParamsArg(GetRetentionPolicyAssignmentsQueryParamsArgTypeField type, string fields, string marker, int? limit) {
            Type = type;
            Fields = fields;
            Marker = marker;
            Limit = limit;
        }
    }
}