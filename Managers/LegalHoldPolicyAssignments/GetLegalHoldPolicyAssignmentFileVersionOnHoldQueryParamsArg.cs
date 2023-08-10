using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetLegalHoldPolicyAssignmentFileVersionOnHoldQueryParamsArg {
        public string Marker { get; }

        public int? Limit { get; }

        public string Fields { get; }

        public GetLegalHoldPolicyAssignmentFileVersionOnHoldQueryParamsArg(string marker, int? limit, string fields) {
            Marker = marker;
            Limit = limit;
            Fields = fields;
        }
    }
}