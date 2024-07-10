using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class ZipDownloadRequestItemsField {
        /// <summary>
        /// The type of the item to add to the archive.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<ZipDownloadRequestItemsTypeField>))]
        public StringEnum<ZipDownloadRequestItemsTypeField> Type { get; }

        /// <summary>
        /// The identifier of the item to add to the archive. When this item is
        /// a folder then this can not be the root folder with ID `0`.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public ZipDownloadRequestItemsField(ZipDownloadRequestItemsTypeField type, string id) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal ZipDownloadRequestItemsField(StringEnum<ZipDownloadRequestItemsTypeField> type, string id) {
            Type = type;
            Id = id;
        }
    }
}