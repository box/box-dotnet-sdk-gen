using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateWebLinkRequestBodyParentField {
        /// <summary>
        /// The ID of parent folder
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateWebLinkRequestBodyParentField(string id) {
            Id = id;
        }
    }
}