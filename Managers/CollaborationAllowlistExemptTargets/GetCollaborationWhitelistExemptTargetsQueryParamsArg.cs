using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollaborationWhitelistExemptTargetsQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetCollaborationWhitelistExemptTargetsQueryParamsArg(string marker, long? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}