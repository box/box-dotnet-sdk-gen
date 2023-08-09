using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class StatusSkillCardStatusField {
        [JsonPropertyName("code")]
        public StatusSkillCardStatusFieldCodeField Code { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        public StatusSkillCardStatusField(StatusSkillCardStatusFieldCodeField code, string message) {
            Code = code;
            Message = message;
        }
    }
}