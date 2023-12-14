using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTermOfServiceUserStatusRequestBody {
        /// <summary>
        /// The terms of service to set the status for.
        /// </summary>
        [JsonPropertyName("tos")]
        public CreateTermOfServiceUserStatusRequestBodyTosField Tos { get; set; }

        /// <summary>
        /// The user to set the status for.
        /// </summary>
        [JsonPropertyName("user")]
        public CreateTermOfServiceUserStatusRequestBodyUserField User { get; set; }

        /// <summary>
        /// Whether the user has accepted the terms.
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool IsAccepted { get; set; }

        public CreateTermOfServiceUserStatusRequestBody(CreateTermOfServiceUserStatusRequestBodyTosField tos, CreateTermOfServiceUserStatusRequestBodyUserField user, bool isAccepted) {
            Tos = tos;
            User = user;
            IsAccepted = isAccepted;
        }
    }
}