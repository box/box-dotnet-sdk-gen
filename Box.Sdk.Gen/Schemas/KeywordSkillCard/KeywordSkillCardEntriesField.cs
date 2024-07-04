using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class KeywordSkillCardEntriesField {
        /// <summary>
        /// The text of the keyword.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; init; }

        public KeywordSkillCardEntriesField() {
            
        }
    }
}