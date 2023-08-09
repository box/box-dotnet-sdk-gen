using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateUserByIdRequestBodyArgNotificationEmailField {
        [JsonPropertyName("email")]
        public string Email { get; }

        public UpdateUserByIdRequestBodyArgNotificationEmailField(string email) {
            Email = email;
        }
    }
}