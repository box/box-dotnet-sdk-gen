using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateWebLinkByIdRequestBodyParentField {
        /// <summary>
        /// The ID of parent item
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public UpdateWebLinkByIdRequestBodyParentField() {
            
        }
    }
}