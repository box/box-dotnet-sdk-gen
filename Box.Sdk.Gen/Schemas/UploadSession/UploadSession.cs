using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class UploadSession {
        /// <summary>
        /// The unique identifier for this session
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `upload_session`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<UploadSessionTypeField>))]
        public StringEnum<UploadSessionTypeField>? Type { get; init; }

        /// <summary>
        /// The date and time when this session expires.
        /// </summary>
        [JsonPropertyName("session_expires_at")]
        public System.DateTimeOffset? SessionExpiresAt { get; init; }

        /// <summary>
        /// The  size in bytes that must be used for all parts of of the
        /// upload.
        /// 
        /// Only the last part is allowed to be of a smaller size.
        /// </summary>
        [JsonPropertyName("part_size")]
        public long? PartSize { get; init; }

        /// <summary>
        /// The total number of parts expected in this upload session,
        /// as determined by the file size and part size.
        /// </summary>
        [JsonPropertyName("total_parts")]
        public int? TotalParts { get; init; }

        /// <summary>
        /// The number of parts that have been uploaded and processed
        /// by the server. This starts at `0`.
        /// 
        /// When committing a file files, inspecting this property can
        /// provide insight if all parts have been uploaded correctly.
        /// </summary>
        [JsonPropertyName("num_parts_processed")]
        public int? NumPartsProcessed { get; init; }

        [JsonPropertyName("session_endpoints")]
        public UploadSessionSessionEndpointsField? SessionEndpoints { get; init; }

        public UploadSession() {
            
        }
    }
}