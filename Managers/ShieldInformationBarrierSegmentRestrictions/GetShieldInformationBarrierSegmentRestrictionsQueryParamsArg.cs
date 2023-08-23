using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetShieldInformationBarrierSegmentRestrictionsQueryParamsArg {
        public string ShieldInformationBarrierSegmentId { get; }

        public string Marker { get; }

        public long? Limit { get; }

        public GetShieldInformationBarrierSegmentRestrictionsQueryParamsArg(string shieldInformationBarrierSegmentId, string marker, long? limit) {
            ShieldInformationBarrierSegmentId = shieldInformationBarrierSegmentId;
            Marker = marker;
            Limit = limit;
        }
    }
}