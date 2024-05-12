using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WebLinkMini : WebLinkBase {
        /// <summary>
        /// The URL this web link points to
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; } = default;

        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; set; } = default;

        /// <summary>
        /// The name of the web link
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        public WebLinkMini(string id, WebLinkBaseTypeField type = WebLinkBaseTypeField.WebLink) : base(id, type) {
            
        }
    }
}