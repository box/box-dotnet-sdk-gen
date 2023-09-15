using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRetentionPolicyAssignmentsQueryParamsArg {
        /// <summary>
        /// The type of the retention policy assignment to retrieve.
        /// </summary>
        public GetRetentionPolicyAssignmentsQueryParamsArgTypeField? Type { get; set; } = default;

        /// <summary>
        /// A comma-separated list of attributes to include in the
        /// response. This can be used to request fields that are
        /// not normally returned in a standard response.
        /// 
        /// Be aware that specifying this parameter will have the
        /// effect that none of the standard fields are returned in
        /// the response unless explicitly specified, instead only
        /// fields for the mini representation are returned, additional
        /// to the fields requested.
        /// </summary>
        public string? Fields { get; set; } = default;

        /// <summary>
        /// Defines the position marker at which to begin returning results. This is
        /// used when paginating using marker-based pagination.
        /// </summary>
        public string? Marker { get; set; } = default;

        /// <summary>
        /// The maximum number of items to return per page.
        /// </summary>
        public long? Limit { get; set; } = default;

        public GetRetentionPolicyAssignmentsQueryParamsArg() {
            
        }
    }
}