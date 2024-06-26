using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class WebLinkBase {
        /// <summary>
        /// The unique identifier for this web link
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `web_link`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<WebLinkBaseTypeField>))]
        public StringEnum<WebLinkBaseTypeField> Type { get; }

        /// <summary>
        /// The entity tag of this web link. Used with `If-Match`
        /// headers.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; init; }

        public WebLinkBase(string id, WebLinkBaseTypeField type = WebLinkBaseTypeField.WebLink) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal WebLinkBase(string id, StringEnum<WebLinkBaseTypeField> type) {
            Id = id;
            Type = WebLinkBaseTypeField.WebLink;
        }
    }
}