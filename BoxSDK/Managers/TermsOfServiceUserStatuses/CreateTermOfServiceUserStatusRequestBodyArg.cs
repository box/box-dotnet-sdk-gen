using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTermOfServiceUserStatusRequestBodyArg {
        /// <summary>
        /// The terms of service to set the status for.
        /// </summary>
        [JsonPropertyName("tos")]
        public CreateTermOfServiceUserStatusRequestBodyArgTosField Tos { get; set; }

        /// <summary>
        /// The user to set the status for.
        /// </summary>
        [JsonPropertyName("user")]
        public CreateTermOfServiceUserStatusRequestBodyArgUserField User { get; set; }

        /// <summary>
        /// Whether the user has accepted the terms.
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool IsAccepted { get; set; }

        public CreateTermOfServiceUserStatusRequestBodyArg(CreateTermOfServiceUserStatusRequestBodyArgTosField tos, CreateTermOfServiceUserStatusRequestBodyArgUserField user, bool isAccepted) {
            Tos = tos;
            User = user;
            IsAccepted = isAccepted;
        }
    }
}