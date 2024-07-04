using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateBoxSkillCardsOnFileRequestBody {
        /// <summary>
        /// `replace`
        /// </summary>
        [JsonPropertyName("op")]
        [JsonConverter(typeof(StringEnumConverter<UpdateBoxSkillCardsOnFileRequestBodyOpField>))]
        public StringEnum<UpdateBoxSkillCardsOnFileRequestBodyOpField>? Op { get; init; }

        /// <summary>
        /// The JSON Path that represents the card to replace. In most cases
        /// this will be in the format `/cards/{index}` where `index` is the
        /// zero-indexed position of the card in the list of cards.
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; init; }

        [JsonPropertyName("value")]
        public KeywordSkillCardOrStatusSkillCardOrTimelineSkillCardOrTranscriptSkillCard? Value { get; init; }

        public UpdateBoxSkillCardsOnFileRequestBody() {
            
        }
    }
}