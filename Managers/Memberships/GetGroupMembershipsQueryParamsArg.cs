using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetGroupMembershipsQueryParamsArg {
        public int? Limit { get; }

        public int? Offset { get; }

        public GetGroupMembershipsQueryParamsArg(int? limit, int? offset) {
            Limit = limit;
            Offset = offset;
        }
    }
}