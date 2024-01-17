using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateAllSkillCardsOnFileRequestBody {
        /// <summary>
        /// Defines the status of this invocation. Set this to `success` when setting Skill cards.
        /// </summary>
        [JsonPropertyName("status")]
        public UpdateAllSkillCardsOnFileRequestBodyStatusField Status { get; set; }

        /// <summary>
        /// The metadata to set for this skill. This is a list of
        /// Box Skills cards. These cards will overwrite any existing Box
        /// skill cards on the file.
        /// </summary>
        [JsonPropertyName("metadata")]
        public UpdateAllSkillCardsOnFileRequestBodyMetadataField Metadata { get; set; }

        /// <summary>
        /// The file to assign the cards to.
        /// </summary>
        [JsonPropertyName("file")]
        public UpdateAllSkillCardsOnFileRequestBodyFileField File { get; set; }

        /// <summary>
        /// The optional file version to assign the cards to.
        /// </summary>
        [JsonPropertyName("file_version")]
        public UpdateAllSkillCardsOnFileRequestBodyFileVersionField? FileVersion { get; set; } = default;

        /// <summary>
        /// A descriptor that defines what items are affected by this call.
        /// 
        /// Set this to the default values when setting a card to a `success`
        /// state, and leave it out in most other situations.
        /// </summary>
        [JsonPropertyName("usage")]
        public UpdateAllSkillCardsOnFileRequestBodyUsageField? Usage { get; set; } = default;

        public UpdateAllSkillCardsOnFileRequestBody(UpdateAllSkillCardsOnFileRequestBodyStatusField status, UpdateAllSkillCardsOnFileRequestBodyMetadataField metadata, UpdateAllSkillCardsOnFileRequestBodyFileField file) {
            Status = status;
            Metadata = metadata;
            File = file;
        }
    }
}