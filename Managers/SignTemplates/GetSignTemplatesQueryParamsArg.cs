using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSignTemplatesQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetSignTemplatesQueryParamsArg(string marker, long? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}