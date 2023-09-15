using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UserNotificationEmailField {
        /// <summary>
        /// The email address to send the notifications to.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; } = default;

        /// <summary>
        /// Specifies if this email address has been confirmed.
        /// </summary>
        [JsonPropertyName("is_confirmed")]
        public bool? IsConfirmed { get; set; } = default;

        public UserNotificationEmailField() {
            
        }
    }
}