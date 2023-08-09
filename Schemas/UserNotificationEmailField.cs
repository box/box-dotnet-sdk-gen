using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UserNotificationEmailField {
        [JsonPropertyName("email")]
        public string Email { get; }

        [JsonPropertyName("is_confirmed")]
        public bool? IsConfirmed { get; }

        public UserNotificationEmailField(string email, bool? isConfirmed) {
            Email = email;
            IsConfirmed = isConfirmed;
        }
    }
}