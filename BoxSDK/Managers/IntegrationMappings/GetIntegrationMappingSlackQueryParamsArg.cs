using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetIntegrationMappingSlackQueryParamsArg {
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

        /// <summary>
        /// Mapped item type, for which the mapping should be returned
        /// </summary>
        public GetIntegrationMappingSlackQueryParamsArgPartnerItemTypeField? PartnerItemType { get; set; } = default;

        /// <summary>
        /// ID of the mapped item, for which the mapping should be returned
        /// </summary>
        public string? PartnerItemId { get; set; } = default;

        /// <summary>
        /// Box item ID, for which the mappings should be returned
        /// </summary>
        public string? BoxItemId { get; set; } = default;

        /// <summary>
        /// Box item type, for which the mappings should be returned
        /// </summary>
        public GetIntegrationMappingSlackQueryParamsArgBoxItemTypeField? BoxItemType { get; set; } = default;

        /// <summary>
        /// Whether the mapping has been manually created
        /// </summary>
        public bool? IsManuallyCreated { get; set; } = default;

        public GetIntegrationMappingSlackQueryParamsArg() {
            
        }
    }
}