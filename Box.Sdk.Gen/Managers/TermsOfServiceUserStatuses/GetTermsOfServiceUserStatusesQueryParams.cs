using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class GetTermsOfServiceUserStatusesQueryParams {
        /// <summary>
        /// The ID of the terms of service.
        /// </summary>
        public string TosId { get; set; }

        /// <summary>
        /// Limits results to the given user ID.
        /// </summary>
        public string? UserId { get; set; } = default;

        public GetTermsOfServiceUserStatusesQueryParams(string tosId) {
            TosId = tosId;
        }
    }
}