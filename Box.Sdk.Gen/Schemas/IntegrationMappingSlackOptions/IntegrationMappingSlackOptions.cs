using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingSlackOptions {
        /// <summary>
        /// Indicates whether or not channel member
        /// access to the underlying box item
        /// should be automatically managed.
        /// Depending on type of channel, access is managed
        /// through creating collaborations or shared links.
        /// </summary>
        [JsonPropertyName("is_access_management_disabled")]
        public bool? IsAccessManagementDisabled { get; init; }

        public IntegrationMappingSlackOptions() {
            
        }
    }
}