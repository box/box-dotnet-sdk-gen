using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class Classification {
        /// <summary>
        /// The name of the classification applied to the item.
        /// </summary>
        [JsonPropertyName("Box__Security__Classification__Key")]
        public string? BoxSecurityClassificationKey { get; set; } = default;

        /// <summary>
        /// The identifier of the item that this metadata instance
        /// has been attached to. This combines the `type` and the `id`
        /// of the parent in the form `{type}_{id}`.
        /// </summary>
        [JsonPropertyName("$parent")]
        public string? Parent { get; set; } = default;

        /// <summary>
        /// `securityClassification-6VMVochwUWo`
        /// </summary>
        [JsonPropertyName("$template")]
        public ClassificationTemplateField? Template { get; set; } = default;

        /// <summary>
        /// The scope of the enterprise that this classification has been
        /// applied for.
        /// 
        /// This will be in the format `enterprise_{enterprise_id}`.
        /// </summary>
        [JsonPropertyName("$scope")]
        public string? Scope { get; set; } = default;

        /// <summary>
        /// The version of the metadata instance. This version starts at 0 and
        /// increases every time a classification is updated.
        /// </summary>
        [JsonPropertyName("$version")]
        public long? Version { get; set; } = default;

        /// <summary>
        /// The unique ID of this classification instance. This will be include
        /// the name of the classification template and a unique ID.
        /// </summary>
        [JsonPropertyName("$type")]
        public string? Type { get; set; } = default;

        /// <summary>
        /// The version of the metadata template. This version starts at 0 and
        /// increases every time the template is updated. This is mostly for internal
        /// use.
        /// </summary>
        [JsonPropertyName("$typeVersion")]
        public double? TypeVersion { get; set; } = default;

        /// <summary>
        /// Whether an end user can change the classification.
        /// </summary>
        [JsonPropertyName("$canEdit")]
        public bool? CanEdit { get; set; } = default;

        public Classification() {
            
        }
    }
}