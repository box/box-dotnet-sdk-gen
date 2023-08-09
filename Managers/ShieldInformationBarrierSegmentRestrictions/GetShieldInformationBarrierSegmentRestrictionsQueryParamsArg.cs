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

        public int? Limit { get; }

        public GetShieldInformationBarrierSegmentRestrictionsQueryParamsArg(string shieldInformationBarrierSegmentId, string marker, int? limit) {
            ShieldInformationBarrierSegmentId = shieldInformationBarrierSegmentId;
            Marker = marker;
            Limit = limit;
        }
    }
}