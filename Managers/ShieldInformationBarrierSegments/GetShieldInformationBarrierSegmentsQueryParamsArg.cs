using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetShieldInformationBarrierSegmentsQueryParamsArg {
        /// <summary>
        /// The ID of the shield information barrier.
        /// </summary>
        public string ShieldInformationBarrierId { get; set; }

        /// <summary>
        /// Defines the position marker at which to begin returning results. This is
        /// used when paginating using marker-based pagination.
        /// 
        /// This requires `usemarker` to be set to `true`.
        /// </summary>
        public string? Marker { get; set; } = default;

        /// <summary>
        /// The maximum number of items to return per page.
        /// </summary>
        public long? Limit { get; set; } = default;

        public GetShieldInformationBarrierSegmentsQueryParamsArg(string shieldInformationBarrierId) {
            ShieldInformationBarrierId = shieldInformationBarrierId;
        }
    }
}