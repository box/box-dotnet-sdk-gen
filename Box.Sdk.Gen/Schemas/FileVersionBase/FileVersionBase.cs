using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersionBase {
        /// <summary>
        /// The unique identifier that represent a file version.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `file_version`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<FileVersionBaseTypeField>))]
        public StringEnum<FileVersionBaseTypeField> Type { get; }

        public FileVersionBase(string id, FileVersionBaseTypeField type = FileVersionBaseTypeField.FileVersion) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal FileVersionBase(string id, StringEnum<FileVersionBaseTypeField> type) {
            Id = id;
            Type = FileVersionBaseTypeField.FileVersion;
        }
    }
}