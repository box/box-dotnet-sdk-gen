using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class GetStoragePolicyAssignmentsQueryParams {
        /// <summary>
        /// Defines the position marker at which to begin returning results. This is
        /// used when paginating using marker-based pagination.
        /// 
        /// This requires `usemarker` to be set to `true`.
        /// </summary>
        public string? Marker { get; set; } = default;

        /// <summary>
        /// The target type to return assignments for
        /// </summary>
        public GetStoragePolicyAssignmentsQueryParamsResolvedForTypeField ResolvedForType { get; set; }

        /// <summary>
        /// The ID of the user or enterprise to return assignments for
        /// </summary>
        public string ResolvedForId { get; set; }

        public GetStoragePolicyAssignmentsQueryParams(GetStoragePolicyAssignmentsQueryParamsResolvedForTypeField resolvedForType, string resolvedForId) {
            ResolvedForType = resolvedForType;
            ResolvedForId = resolvedForId;
        }
    }
}