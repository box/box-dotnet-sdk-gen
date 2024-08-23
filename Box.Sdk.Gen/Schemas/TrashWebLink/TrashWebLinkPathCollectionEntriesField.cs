using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TrashWebLinkPathCollectionEntriesField {
        [JsonInclude]
        [JsonPropertyName("_issequence_idSet")]
        protected bool _isSequenceIdSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isetagSet")]
        protected bool _isEtagSet { get; set; }

        protected string? _sequenceId { get; set; }

        protected string? _etag { get; set; }

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
        public string? SequenceId { get => _sequenceId; init { _sequenceId = value; _isSequenceIdSet = true; } }

        /// <summary>
        /// This field is null for the Trash folder
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get => _etag; init { _etag = value; _isEtagSet = true; } }

        /// <summary>
        /// The name of the Trash folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        public TrashWebLinkPathCollectionEntriesField() {
            
        }
    }
}