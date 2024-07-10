using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

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