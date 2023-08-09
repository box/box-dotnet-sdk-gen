using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSignTemplatesQueryParamsArg {
        public string Marker { get; }

        public int? Limit { get; }

        public GetSignTemplatesQueryParamsArg(string marker, int? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}