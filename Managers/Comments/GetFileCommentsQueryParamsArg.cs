using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileCommentsQueryParamsArg {
        public string Fields { get; }

        public int? Limit { get; }

        public int? Offset { get; }

        public GetFileCommentsQueryParamsArg(string fields, int? limit, int? offset) {
            Fields = fields;
            Limit = limit;
            Offset = offset;
        }
    }
}