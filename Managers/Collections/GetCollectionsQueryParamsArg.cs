using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollectionsQueryParamsArg {
        public string Fields { get; }

        public int? Offset { get; }

        public int? Limit { get; }

        public GetCollectionsQueryParamsArg(string fields, int? offset, int? limit) {
            Fields = fields;
            Offset = offset;
            Limit = limit;
        }
    }
}