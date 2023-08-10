using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetShieldInformationBarrierReportsQueryParamsArg {
        public string ShieldInformationBarrierId { get; }

        public string Marker { get; }

        public int? Limit { get; }

        public GetShieldInformationBarrierReportsQueryParamsArg(string shieldInformationBarrierId, string marker, int? limit) {
            ShieldInformationBarrierId = shieldInformationBarrierId;
            Marker = marker;
            Limit = limit;
        }
    }
}