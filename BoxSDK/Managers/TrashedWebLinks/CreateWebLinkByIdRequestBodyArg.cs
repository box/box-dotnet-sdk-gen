using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebLinkByIdRequestBodyArg {
        /// <summary>
        /// An optional new name for the web link.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        [JsonPropertyName("parent")]
        public CreateWebLinkByIdRequestBodyArgParentField? Parent { get; set; } = default;

        public CreateWebLinkByIdRequestBodyArg() {
            
        }
    }
}