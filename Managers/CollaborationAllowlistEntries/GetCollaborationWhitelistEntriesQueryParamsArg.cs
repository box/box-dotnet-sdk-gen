using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollaborationWhitelistEntriesQueryParamsArg {
        public string Marker { get; }

        public int? Limit { get; }

        public GetCollaborationWhitelistEntriesQueryParamsArg(string marker, int? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}