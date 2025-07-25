using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class FolderReference : ISerializable {
        /// <summary>
        /// The value will always be `folder`.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<FolderReferenceTypeField>))]
        public StringEnum<FolderReferenceTypeField> Type { get; }

        /// <summary>
        /// ID of the folder.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public FolderReference(string id, FolderReferenceTypeField type = FolderReferenceTypeField.Folder) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal FolderReference(string id, StringEnum<FolderReferenceTypeField> type) {
            Type = FolderReferenceTypeField.Folder;
            Id = id;
        }
        internal string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}