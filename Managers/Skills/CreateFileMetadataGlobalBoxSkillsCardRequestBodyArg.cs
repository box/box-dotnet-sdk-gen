using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileMetadataGlobalBoxSkillsCardRequestBodyArg {
        [JsonPropertyName("cards")]
        public IReadOnlyList<CreateFileMetadataGlobalBoxSkillsCardRequestBodyArgCardsField> Cards { get; }

        public CreateFileMetadataGlobalBoxSkillsCardRequestBodyArg(IReadOnlyList<CreateFileMetadataGlobalBoxSkillsCardRequestBodyArgCardsField> cards) {
            Cards = cards;
        }
    }
}