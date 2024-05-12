using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class TimelineSkillCardSkillCardTitleField {
        /// <summary>
        /// An optional identifier for the title.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; } = default;

        /// <summary>
        /// The actual title to show in the UI.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        public TimelineSkillCardSkillCardTitleField(string message) {
            Message = message;
        }
    }
}