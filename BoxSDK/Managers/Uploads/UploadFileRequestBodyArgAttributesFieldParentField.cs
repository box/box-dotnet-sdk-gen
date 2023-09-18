using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileRequestBodyArgAttributesFieldParentField {
        /// <summary>
        /// The id of the parent folder. Use
        /// `0` for the user's root folder.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public UploadFileRequestBodyArgAttributesFieldParentField(string id) {
            Id = id;
        }
    }
}