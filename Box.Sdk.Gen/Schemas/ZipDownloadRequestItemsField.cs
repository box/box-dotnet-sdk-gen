using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ZipDownloadRequestItemsField {
        /// <summary>
        /// The type of the item to add to the archive.
        /// </summary>
        [JsonPropertyName("type")]
        public ZipDownloadRequestItemsTypeField Type { get; set; }

        /// <summary>
        /// The identifier of the item to add to the archive. When this item is
        /// a folder then this can not be the root folder with ID `0`.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public ZipDownloadRequestItemsField(ZipDownloadRequestItemsTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}