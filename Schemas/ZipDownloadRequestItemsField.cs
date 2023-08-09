using System.IO;
using Unions;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    public class ZipDownloadRequestItemsField {
        [JsonPropertyName("type")]
        public ZipDownloadRequestItemsFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public ZipDownloadRequestItemsField(ZipDownloadRequestItemsFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}