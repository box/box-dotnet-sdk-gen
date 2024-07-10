using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SkillInvocationTokenField {
        /// <summary>
        /// The basics of an access token
        /// </summary>
        [JsonPropertyName("read")]
        public SkillInvocationTokenReadField? Read { get; init; }

        /// <summary>
        /// The basics of an access token
        /// </summary>
        [JsonPropertyName("write")]
        public SkillInvocationTokenWriteField? Write { get; init; }

        public SkillInvocationTokenField() {
            
        }
    }
}