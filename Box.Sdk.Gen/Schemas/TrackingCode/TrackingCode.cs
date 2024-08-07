using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class TrackingCode {
        /// <summary>
        /// `tracking_code`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<TrackingCodeTypeField>))]
        public StringEnum<TrackingCodeTypeField>? Type { get; init; }

        /// <summary>
        /// The name of the tracking code, which must be preconfigured in
        /// the Admin Console
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The value of the tracking code
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; init; }

        public TrackingCode() {
            
        }
    }
}