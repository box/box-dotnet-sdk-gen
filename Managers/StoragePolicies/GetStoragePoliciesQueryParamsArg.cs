using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetStoragePoliciesQueryParamsArg {
        public string Fields { get; }

        public string Marker { get; }

        public int? Limit { get; }

        public GetStoragePoliciesQueryParamsArg(string fields, string marker, int? limit) {
            Fields = fields;
            Marker = marker;
            Limit = limit;
        }
    }
}