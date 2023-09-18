using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebLinkByIdRequestBodyArgParentField {
        /// <summary>
        /// The ID of parent item
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public CreateWebLinkByIdRequestBodyArgParentField() {
            
        }
    }
}