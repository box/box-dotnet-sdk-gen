using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class ZipDownloadNameConflictsField {
        /// <summary>
        /// The identifier of the item
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of this item
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<ZipDownloadNameConflictsTypeField>))]
        public StringEnum<ZipDownloadNameConflictsTypeField>? Type { get; init; }

        /// <summary>
        /// The original name of this item
        /// </summary>
        [JsonPropertyName("original_name")]
        public string? OriginalName { get; init; }

        /// <summary>
        /// The new name of this item as it will appear in the
        /// downloaded `zip` archive.
        /// </summary>
        [JsonPropertyName("download_name")]
        public string? DownloadName { get; init; }

        public ZipDownloadNameConflictsField() {
            
        }
    }
}