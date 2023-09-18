using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataCascadePolicyParentField {
        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        public MetadataCascadePolicyParentFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The ID of the folder the policy is applied to.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public MetadataCascadePolicyParentField() {
            
        }
    }
}