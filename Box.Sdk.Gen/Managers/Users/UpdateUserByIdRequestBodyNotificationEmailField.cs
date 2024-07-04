using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateUserByIdRequestBodyNotificationEmailField {
        /// <summary>
        /// The email address to send the notifications to.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; init; }

        public UpdateUserByIdRequestBodyNotificationEmailField() {
            
        }
    }
}