using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetIntegrationMappingSlackQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetIntegrationMappingSlackQueryParamsArgPartnerItemTypeField PartnerItemType { get; }

        public string PartnerItemId { get; }

        public string BoxItemId { get; }

        public GetIntegrationMappingSlackQueryParamsArgBoxItemTypeField BoxItemType { get; }

        public bool? IsManuallyCreated { get; }

        public GetIntegrationMappingSlackQueryParamsArg(string marker, long? limit, GetIntegrationMappingSlackQueryParamsArgPartnerItemTypeField partnerItemType, string partnerItemId, string boxItemId, GetIntegrationMappingSlackQueryParamsArgBoxItemTypeField boxItemType, bool? isManuallyCreated) {
            Marker = marker;
            Limit = limit;
            PartnerItemType = partnerItemType;
            PartnerItemId = partnerItemId;
            BoxItemId = boxItemId;
            BoxItemType = boxItemType;
            IsManuallyCreated = isManuallyCreated;
        }
    }
}