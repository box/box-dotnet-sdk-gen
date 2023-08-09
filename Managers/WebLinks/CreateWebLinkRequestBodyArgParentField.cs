using System.IO;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebLinkRequestBodyArgParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateWebLinkRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}