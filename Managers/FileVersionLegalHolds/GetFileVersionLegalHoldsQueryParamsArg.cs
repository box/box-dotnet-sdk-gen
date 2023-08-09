using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileVersionLegalHoldsQueryParamsArg {
        public string PolicyId { get; }

        public string Marker { get; }

        public int? Limit { get; }

        public GetFileVersionLegalHoldsQueryParamsArg(string policyId, string marker, int? limit) {
            PolicyId = policyId;
            Marker = marker;
            Limit = limit;
        }
    }
}