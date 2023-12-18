using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateBoxSkillCardsOnFileRequestBody {
        /// <summary>
        /// A list of Box Skill cards to apply to this file.
        /// </summary>
        [JsonPropertyName("cards")]
        public IReadOnlyList<KeywordSkillCardOrStatusSkillCardOrTimelineSkillCardOrTranscriptSkillCard> Cards { get; set; }

        public CreateBoxSkillCardsOnFileRequestBody(IReadOnlyList<KeywordSkillCardOrStatusSkillCardOrTimelineSkillCardOrTranscriptSkillCard> cards) {
            Cards = cards;
        }
    }
}