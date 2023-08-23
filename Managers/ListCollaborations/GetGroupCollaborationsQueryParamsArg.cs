using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetGroupCollaborationsQueryParamsArg {
        public long? Limit { get; }

        public long? Offset { get; }

        public GetGroupCollaborationsQueryParamsArg(long? limit, long? offset) {
            Limit = limit;
            Offset = offset;
        }
    }
}