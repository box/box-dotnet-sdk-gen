using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetStoragePolicyAssignmentsQueryParamsArg {
        public string Marker { get; }

        public GetStoragePolicyAssignmentsQueryParamsArgResolvedForTypeField ResolvedForType { get; }

        public string ResolvedForId { get; }

        public GetStoragePolicyAssignmentsQueryParamsArg(string marker, GetStoragePolicyAssignmentsQueryParamsArgResolvedForTypeField resolvedForType, string resolvedForId) {
            Marker = marker;
            ResolvedForType = resolvedForType;
            ResolvedForId = resolvedForId;
        }
    }
}