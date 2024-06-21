using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TrashWebLinkPathCollectionEntriesField {
        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<TrashWebLinkPathCollectionEntriesTypeField>))]
        public StringEnum<TrashWebLinkPathCollectionEntriesTypeField>? Type { get; init; }

        /// <summary>
        /// The unique identifier that represent a folder.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// This field is null for the Trash folder
        /// </summary>
        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; init; }

        /// <summary>
        /// This field is null for the Trash folder
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; init; }

        /// <summary>
        /// The name of the Trash folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        public TrashWebLinkPathCollectionEntriesField() {
            
        }
    }
}