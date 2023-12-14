using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTermOfServiceUserStatusByIdRequestBody {
        /// <summary>
        /// Whether the user has accepted the terms.
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool IsAccepted { get; set; }

        public UpdateTermOfServiceUserStatusByIdRequestBody(bool isAccepted) {
            IsAccepted = isAccepted;
        }
    }
}