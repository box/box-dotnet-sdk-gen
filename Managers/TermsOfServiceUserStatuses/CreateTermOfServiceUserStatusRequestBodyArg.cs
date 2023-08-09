using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTermOfServiceUserStatusRequestBodyArg {
        [JsonPropertyName("tos")]
        public CreateTermOfServiceUserStatusRequestBodyArgTosField Tos { get; }

        [JsonPropertyName("user")]
        public CreateTermOfServiceUserStatusRequestBodyArgUserField User { get; }

        [JsonPropertyName("is_accepted")]
        public bool IsAccepted { get; }

        public CreateTermOfServiceUserStatusRequestBodyArg(CreateTermOfServiceUserStatusRequestBodyArgTosField tos, CreateTermOfServiceUserStatusRequestBodyArgUserField user, bool isAccepted) {
            Tos = tos;
            User = user;
            IsAccepted = isAccepted;
        }
    }
}