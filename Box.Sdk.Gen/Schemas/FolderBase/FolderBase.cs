using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class FolderBase {
        /// <summary>
        /// The unique identifier that represent a folder.
        /// 
        /// The ID for any folder can be determined
        /// by visiting a folder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/folders/123`
        /// the `folder_id` is `123`.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The HTTP `etag` of this folder. This can be used within some API
        /// endpoints in the `If-Match` and `If-None-Match` headers to only
        /// perform changes on the folder if (no) changes have happened.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; init; }

        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<FolderBaseTypeField>))]
        public StringEnum<FolderBaseTypeField> Type { get; }

        public FolderBase(string id, FolderBaseTypeField type = FolderBaseTypeField.Folder) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal FolderBase(string id, StringEnum<FolderBaseTypeField> type) {
            Id = id;
            Type = FolderBaseTypeField.Folder;
        }
    }
}