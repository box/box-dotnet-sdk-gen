using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateSkillInvocationByIdRequestBody {
        /// <summary>
        /// Defines the status of this invocation. Set this to `success` when setting Skill cards.
        /// </summary>
        [JsonPropertyName("status")]
        public UpdateSkillInvocationByIdRequestBodyStatusField Status { get; set; }

        /// <summary>
        /// The metadata to set for this skill. This is a list of
        /// Box Skills cards. These cards will overwrite any existing Box
        /// skill cards on the file.
        /// </summary>
        [JsonPropertyName("metadata")]
        public UpdateSkillInvocationByIdRequestBodyMetadataField Metadata { get; set; }

        /// <summary>
        /// The file to assign the cards to.
        /// </summary>
        [JsonPropertyName("file")]
        public UpdateSkillInvocationByIdRequestBodyFileField File { get; set; }

        /// <summary>
        /// The optional file version to assign the cards to.
        /// </summary>
        [JsonPropertyName("file_version")]
        public UpdateSkillInvocationByIdRequestBodyFileVersionField? FileVersion { get; set; } = default;

        /// <summary>
        /// A descriptor that defines what items are affected by this call.
        /// 
        /// Set this to the default values when setting a card to a `success`
        /// state, and leave it out in most other situations.
        /// </summary>
        [JsonPropertyName("usage")]
        public UpdateSkillInvocationByIdRequestBodyUsageField? Usage { get; set; } = default;

        public UpdateSkillInvocationByIdRequestBody(UpdateSkillInvocationByIdRequestBodyStatusField status, UpdateSkillInvocationByIdRequestBodyMetadataField metadata, UpdateSkillInvocationByIdRequestBodyFileField file) {
            Status = status;
            Metadata = metadata;
            File = file;
        }
    }
}