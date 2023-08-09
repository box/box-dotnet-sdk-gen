using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebLinkByIdRequestBodyArgParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateWebLinkByIdRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}