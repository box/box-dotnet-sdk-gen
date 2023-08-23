using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetGroupMembershipsQueryParamsArg {
        public long? Limit { get; }

        public long? Offset { get; }

        public GetGroupMembershipsQueryParamsArg(long? limit, long? offset) {
            Limit = limit;
            Offset = offset;
        }
    }
}