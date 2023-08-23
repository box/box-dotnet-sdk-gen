using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetUserMembershipsQueryParamsArg {
        public long? Limit { get; }

        public long? Offset { get; }

        public GetUserMembershipsQueryParamsArg(long? limit, long? offset) {
            Limit = limit;
            Offset = offset;
        }
    }
}