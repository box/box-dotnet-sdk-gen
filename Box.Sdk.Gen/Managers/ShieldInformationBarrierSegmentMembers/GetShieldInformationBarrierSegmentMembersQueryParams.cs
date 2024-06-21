using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class GetShieldInformationBarrierSegmentMembersQueryParams {
        /// <summary>
        /// The ID of the shield information barrier segment.
        /// </summary>
        public string ShieldInformationBarrierSegmentId { get; }

        /// <summary>
        /// Defines the position marker at which to begin returning results. This is
        /// used when paginating using marker-based pagination.
        /// 
        /// This requires `usemarker` to be set to `true`.
        /// </summary>
        public string? Marker { get; init; }

        /// <summary>
        /// The maximum number of items to return per page.
        /// </summary>
        public long? Limit { get; init; }

        public GetShieldInformationBarrierSegmentMembersQueryParams(string shieldInformationBarrierSegmentId) {
            ShieldInformationBarrierSegmentId = shieldInformationBarrierSegmentId;
        }
    }
}