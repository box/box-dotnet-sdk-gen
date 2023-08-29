using System.IO;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateInviteRequestBodyArgEnterpriseField {
        /// <summary>
        /// The ID of the enterprise
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateInviteRequestBodyArgEnterpriseField(string id) {
            Id = id;
        }
    }
}