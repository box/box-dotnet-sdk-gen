using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileVersionsQueryParamsArg {
        public string Fields { get; }

        public int? Limit { get; }

        public int? Offset { get; }

        public GetFileVersionsQueryParamsArg(string fields, int? limit, int? offset) {
            Fields = fields;
            Limit = limit;
            Offset = offset;
        }
    }
}