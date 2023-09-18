using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class IntegrationMappingSlackOptions {
        /// <summary>
        /// Indicates whether or not channel member
        /// access to the underlying box item
        /// should be automatically managed.
        /// Depending on type of channel, access is managed
        /// through creating collaborations or shared links.
        /// </summary>
        [JsonPropertyName("is_access_management_disabled")]
        public bool? IsAccessManagementDisabled { get; set; } = default;

        public IntegrationMappingSlackOptions() {
            
        }
    }
}