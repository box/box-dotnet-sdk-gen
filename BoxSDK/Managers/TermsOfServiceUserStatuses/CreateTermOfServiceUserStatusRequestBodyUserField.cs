using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTermOfServiceUserStatusRequestBodyUserField {
        /// <summary>
        /// The type of object.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateTermOfServiceUserStatusRequestBodyUserTypeField Type { get; set; }

        /// <summary>
        /// The ID of user
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateTermOfServiceUserStatusRequestBodyUserField(CreateTermOfServiceUserStatusRequestBodyUserTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}