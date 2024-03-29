using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class TranscriptSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        public TranscriptSkillCardSkillTypeField Type { get; set; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public TranscriptSkillCardSkillField(string id, TranscriptSkillCardSkillTypeField type = TranscriptSkillCardSkillTypeField.Service) {
            Type = type;
            Id = id;
        }
    }
}