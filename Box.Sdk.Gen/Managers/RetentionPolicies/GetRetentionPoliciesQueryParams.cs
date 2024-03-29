using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class GetRetentionPoliciesQueryParams {
        /// <summary>
        /// Filters results by a case sensitive prefix of the name of
        /// retention policies.
        /// </summary>
        public string? PolicyName { get; set; } = default;

        /// <summary>
        /// Filters results by the type of retention policy.
        /// </summary>
        public GetRetentionPoliciesQueryParamsPolicyTypeField? PolicyType { get; set; } = default;

        /// <summary>
        /// Filters results by the ID of the user who created policy.
        /// </summary>
        public string? CreatedByUserId { get; set; } = default;

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
        public IReadOnlyList<string>? Fields { get; set; } = default;

        /// <summary>
        /// The maximum number of items to return per page.
        /// </summary>
        public long? Limit { get; set; } = default;

        /// <summary>
        /// Defines the position marker at which to begin returning results. This is
        /// used when paginating using marker-based pagination.
        /// </summary>
        public string? Marker { get; set; } = default;

        public GetRetentionPoliciesQueryParams() {
            
        }
    }
}