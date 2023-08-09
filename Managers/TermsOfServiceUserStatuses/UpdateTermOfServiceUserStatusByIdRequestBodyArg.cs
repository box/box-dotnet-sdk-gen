using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTermOfServiceUserStatusByIdRequestBodyArg {
        [JsonPropertyName("is_accepted")]
        public bool IsAccepted { get; }

        public UpdateTermOfServiceUserStatusByIdRequestBodyArg(bool isAccepted) {
            IsAccepted = isAccepted;
        }
    }
}