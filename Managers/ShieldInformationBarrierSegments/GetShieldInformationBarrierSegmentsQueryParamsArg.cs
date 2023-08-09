using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetShieldInformationBarrierSegmentsQueryParamsArg {
        public string ShieldInformationBarrierId { get; }

        public string Marker { get; }

        public int? Limit { get; }

        public GetShieldInformationBarrierSegmentsQueryParamsArg(string shieldInformationBarrierId, string marker, int? limit) {
            ShieldInformationBarrierId = shieldInformationBarrierId;
            Marker = marker;
            Limit = limit;
        }
    }
}