using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTermOfServiceUserStatusRequestBodyArgUserField {
        /// <summary>
        /// The type of object.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateTermOfServiceUserStatusRequestBodyArgUserFieldTypeField Type { get; set; }

        /// <summary>
        /// The ID of user
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateTermOfServiceUserStatusRequestBodyArgUserField(CreateTermOfServiceUserStatusRequestBodyArgUserFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}