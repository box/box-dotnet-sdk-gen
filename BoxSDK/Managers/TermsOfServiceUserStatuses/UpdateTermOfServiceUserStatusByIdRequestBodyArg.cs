using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTermOfServiceUserStatusByIdRequestBodyArg {
        /// <summary>
        /// Whether the user has accepted the terms.
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool IsAccepted { get; set; }

        public UpdateTermOfServiceUserStatusByIdRequestBodyArg(bool isAccepted) {
            IsAccepted = isAccepted;
        }
    }
}