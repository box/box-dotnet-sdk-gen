using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRecentItemsQueryParamsArg {
        public string Fields { get; }

        public int? Limit { get; }

        public string Marker { get; }

        public GetRecentItemsQueryParamsArg(string fields, int? limit, string marker) {
            Fields = fields;
            Limit = limit;
            Marker = marker;
        }
    }
}