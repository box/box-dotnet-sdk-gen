using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class IntegrationMappingSlackOptions {
        [JsonPropertyName("is_access_management_disabled")]
        public bool? IsAccessManagementDisabled { get; }

        public IntegrationMappingSlackOptions(bool? isAccessManagementDisabled) {
            IsAccessManagementDisabled = isAccessManagementDisabled;
        }
    }
}