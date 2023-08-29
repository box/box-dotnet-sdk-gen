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
        /// <summary>
        /// A list of Box Skill cards to apply to this file.
        /// </summary>
        [JsonPropertyName("cards")]
        public IReadOnlyList<UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField>? Cards { get; set; } = default;

        public UpdateSkillInvocationByIdRequestBodyArgMetadataField() {
            
        }
    }
}