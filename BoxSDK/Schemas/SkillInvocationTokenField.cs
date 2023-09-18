using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocationTokenField {
        /// <summary>
        /// The basics of an access token
        /// </summary>
        [JsonPropertyName("read")]
        public SkillInvocationTokenFieldReadField? Read { get; set; } = default;

        /// <summary>
        /// The basics of an access token
        /// </summary>
        [JsonPropertyName("write")]
        public SkillInvocationTokenFieldWriteField? Write { get; set; } = default;

        public SkillInvocationTokenField() {
            
        }
    }
}