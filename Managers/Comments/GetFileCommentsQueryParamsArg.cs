using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileCommentsQueryParamsArg {
        public string Fields { get; }

        public long? Limit { get; }

        public long? Offset { get; }

        public GetFileCommentsQueryParamsArg(string fields, long? limit, long? offset) {
            Fields = fields;
            Limit = limit;
            Offset = offset;
        }
    }
}