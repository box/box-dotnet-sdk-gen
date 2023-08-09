using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetGroupsQueryParamsArg {
        public string FilterTerm { get; }

        public string Fields { get; }

        public int? Limit { get; }

        public int? Offset { get; }

        public GetGroupsQueryParamsArg(string filterTerm, string fields, int? limit, int? offset) {
            FilterTerm = filterTerm;
            Fields = fields;
            Limit = limit;
            Offset = offset;
        }
    }
}