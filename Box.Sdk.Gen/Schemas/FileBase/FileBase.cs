using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class FileBase {
        /// <summary>
        /// The unique identifier that represent a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The HTTP `etag` of this file. This can be used within some API
        /// endpoints in the `If-Match` and `If-None-Match` headers to only
        /// perform changes on the file if (no) changes have happened.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; init; }

        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<FileBaseTypeField>))]
        public StringEnum<FileBaseTypeField> Type { get; }

        public FileBase(string id, FileBaseTypeField type = FileBaseTypeField.File) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal FileBase(string id, StringEnum<FileBaseTypeField> type) {
            Id = id;
            Type = FileBaseTypeField.File;
        }
    }
}