using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateAllSkillCardsOnFileRequestBodyMetadataField {
        /// <summary>
        /// A list of Box Skill cards to apply to this file.
        /// </summary>
        [JsonPropertyName("cards")]
        public IReadOnlyList<KeywordSkillCardOrStatusSkillCardOrTimelineSkillCardOrTranscriptSkillCard>? Cards { get; init; }

        public UpdateAllSkillCardsOnFileRequestBodyMetadataField() {
            
        }
    }
}