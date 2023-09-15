using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkByIdRequestBodyArgParentField {
        /// <summary>
        /// The ID of parent item
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public UpdateWebLinkByIdRequestBodyArgParentField() {
            
        }
    }
}