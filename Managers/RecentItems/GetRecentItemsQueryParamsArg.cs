using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRecentItemsQueryParamsArg {
        public string Fields { get; }

        public long? Limit { get; }

        public string Marker { get; }

        public GetRecentItemsQueryParamsArg(string fields, long? limit, string marker) {
            Fields = fields;
            Limit = limit;
            Marker = marker;
        }
    }
}