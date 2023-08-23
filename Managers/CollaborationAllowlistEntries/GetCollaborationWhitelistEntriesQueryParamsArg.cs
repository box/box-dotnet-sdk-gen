using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollaborationWhitelistEntriesQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetCollaborationWhitelistEntriesQueryParamsArg(string marker, long? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}