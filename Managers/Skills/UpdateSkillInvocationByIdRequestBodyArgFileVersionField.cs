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
    public class UpdateSkillInvocationByIdRequestBodyArgFileVersionField {
        [JsonPropertyName("type")]
        public UpdateSkillInvocationByIdRequestBodyArgFileVersionFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public UpdateSkillInvocationByIdRequestBodyArgFileVersionField(UpdateSkillInvocationByIdRequestBodyArgFileVersionFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}