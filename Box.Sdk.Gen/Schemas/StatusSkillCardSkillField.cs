using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class StatusSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        public StatusSkillCardSkillTypeField Type { get; set; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public StatusSkillCardSkillField(string id, StatusSkillCardSkillTypeField type = StatusSkillCardSkillTypeField.Service) {
            Type = type;
            Id = id;
        }
    }
}