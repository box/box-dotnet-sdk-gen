using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetGroupsQueryParamsArg {
        public string FilterTerm { get; }

        public string Fields { get; }

        public long? Limit { get; }

        public long? Offset { get; }

        public GetGroupsQueryParamsArg(string filterTerm, string fields, long? limit, long? offset) {
            FilterTerm = filterTerm;
            Fields = fields;
            Limit = limit;
            Offset = offset;
        }
    }
}