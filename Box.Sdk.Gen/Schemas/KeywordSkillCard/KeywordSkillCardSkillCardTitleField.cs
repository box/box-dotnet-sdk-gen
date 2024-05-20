using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class KeywordSkillCardSkillCardTitleField {
        /// <summary>
        /// An optional identifier for the title.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; init; }

        /// <summary>
        /// The actual title to show in the UI.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; }

        public KeywordSkillCardSkillCardTitleField(string message) {
            Message = message;
        }
    }
}