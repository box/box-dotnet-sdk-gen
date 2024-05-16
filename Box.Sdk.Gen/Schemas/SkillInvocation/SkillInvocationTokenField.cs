using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SkillInvocationTokenField {
        /// <summary>
        /// The basics of an access token
        /// </summary>
        [JsonPropertyName("read")]
        public SkillInvocationTokenReadField? Read { get; set; } = default;

        /// <summary>
        /// The basics of an access token
        /// </summary>
        [JsonPropertyName("write")]
        public SkillInvocationTokenWriteField? Write { get; set; } = default;

        public SkillInvocationTokenField() {
            
        }
    }
}