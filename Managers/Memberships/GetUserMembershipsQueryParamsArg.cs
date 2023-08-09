using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetUserMembershipsQueryParamsArg {
        public int? Limit { get; }

        public int? Offset { get; }

        public GetUserMembershipsQueryParamsArg(int? limit, int? offset) {
            Limit = limit;
            Offset = offset;
        }
    }
}