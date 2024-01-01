using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class MetadataCascadePolicyParentField {
        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        public MetadataCascadePolicyParentTypeField? Type { get; set; } = default;

        /// <summary>
        /// The ID of the folder the policy is applied to.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public MetadataCascadePolicyParentField() {
            
        }
    }
}