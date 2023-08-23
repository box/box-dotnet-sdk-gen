using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileCollaborationsQueryParamsArg {
        public string Fields { get; }

        public long? Limit { get; }

        public string Marker { get; }

        public GetFileCollaborationsQueryParamsArg(string fields, long? limit, string marker) {
            Fields = fields;
            Limit = limit;
            Marker = marker;
        }
    }
}