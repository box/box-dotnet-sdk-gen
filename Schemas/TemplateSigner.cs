using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TemplateSigner {
        [JsonPropertyName("inputs")]
        public IReadOnlyList<TemplateSignerInput> Inputs { get; }

        [JsonPropertyName("email")]
        public string Email { get; }

        [JsonPropertyName("role")]
        public TemplateSignerRoleField Role { get; }

        [JsonPropertyName("is_in_person")]
        public bool? IsInPerson { get; }

        [JsonPropertyName("order")]
        public int? Order { get; }

        public TemplateSigner(IReadOnlyList<TemplateSignerInput> inputs, string email, TemplateSignerRoleField role, bool? isInPerson, int? order) {
            Inputs = inputs;
            Email = email;
            Role = role;
            IsInPerson = isInPerson;
            Order = order;
        }
    }
}