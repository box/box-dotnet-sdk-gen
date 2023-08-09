using System.IO;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateInviteRequestBodyArgEnterpriseField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateInviteRequestBodyArgEnterpriseField(string id) {
            Id = id;
        }
    }
}