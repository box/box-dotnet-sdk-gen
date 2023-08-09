using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateSkillInvocationByIdRequestBodyArgFileField {
        [JsonPropertyName("type")]
        public UpdateSkillInvocationByIdRequestBodyArgFileFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public UpdateSkillInvocationByIdRequestBodyArgFileField(UpdateSkillInvocationByIdRequestBodyArgFileFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}