using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class DevicePinner {
        /// <summary>
        /// The unique identifier for this device pin.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `device_pinner`
        /// </summary>
        [JsonPropertyName("type")]
        public DevicePinnerTypeField? Type { get; init; }

        [JsonPropertyName("owned_by")]
        public UserMini? OwnedBy { get; init; }

        /// <summary>
        /// The type of device being pinned
        /// </summary>
        [JsonPropertyName("product_name")]
        public string? ProductName { get; init; }

        public DevicePinner() {
            
        }
    }
}