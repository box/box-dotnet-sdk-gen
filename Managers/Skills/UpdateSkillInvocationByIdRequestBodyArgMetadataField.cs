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
    public class UpdateSkillInvocationByIdRequestBodyArgMetadataField {
        [JsonPropertyName("cards")]
        public IReadOnlyList<UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField> Cards { get; }

        public UpdateSkillInvocationByIdRequestBodyArgMetadataField(IReadOnlyList<UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField> cards) {
            Cards = cards;
        }
    }
}