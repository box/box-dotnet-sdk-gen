using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataBase {
        /// <summary>
        /// The identifier of the item that this metadata instance
        /// has been attached to. This combines the `type` and the `id`
        /// of the parent in the form `{type}_{id}`.
        /// </summary>
        [JsonPropertyName("$parent")]
        public string? Parent { get; set; } = default;

        /// <summary>
        /// The name of the template
        /// </summary>
        [JsonPropertyName("$template")]
        public string? Template { get; set; } = default;

        /// <summary>
        /// An ID for the scope in which this template
        /// has been applied. This will be `enterprise_{enterprise_id}` for templates
        /// defined for use in this enterprise, and `global` for general templates
        /// that are available to all enterprises using Box.
        /// </summary>
        [JsonPropertyName("$scope")]
        public string? Scope { get; set; } = default;

        /// <summary>
        /// The version of the metadata instance. This version starts at 0 and
        /// increases every time a user-defined property is modified.
        /// </summary>
        [JsonPropertyName("$version")]
        public long? Version { get; set; } = default;

        public MetadataBase() {
            
        }
    }
}