using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollectionsQueryParamsArg {
        public string Fields { get; }

        public long? Offset { get; }

        public long? Limit { get; }

        public GetCollectionsQueryParamsArg(string fields, long? offset, long? limit) {
            Fields = fields;
            Offset = offset;
            Limit = limit;
        }
    }
}