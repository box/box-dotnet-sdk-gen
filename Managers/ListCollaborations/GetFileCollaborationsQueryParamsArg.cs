using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileCollaborationsQueryParamsArg {
        public string Fields { get; }

        public int? Limit { get; }

        public string Marker { get; }

        public GetFileCollaborationsQueryParamsArg(string fields, int? limit, string marker) {
            Fields = fields;
            Limit = limit;
            Marker = marker;
        }
    }
}