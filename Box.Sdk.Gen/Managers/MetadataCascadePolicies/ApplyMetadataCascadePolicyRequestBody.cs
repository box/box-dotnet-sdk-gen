using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class ApplyMetadataCascadePolicyRequestBody {
        /// <summary>
        /// Describes the desired behavior when dealing with the conflict
        /// where a metadata template already has an instance applied
        /// to a child.
        /// 
        /// * `none` will preserve the existing value on the file
        /// * `overwrite` will force-apply the templates values over
        ///   any existing values.
        /// </summary>
        [JsonPropertyName("conflict_resolution")]
        [JsonConverter(typeof(StringEnumConverter<ApplyMetadataCascadePolicyRequestBodyConflictResolutionField>))]
        public StringEnum<ApplyMetadataCascadePolicyRequestBodyConflictResolutionField> ConflictResolution { get; }

        public ApplyMetadataCascadePolicyRequestBody(ApplyMetadataCascadePolicyRequestBodyConflictResolutionField conflictResolution) {
            ConflictResolution = conflictResolution;
        }
        
        [JsonConstructorAttribute]
        internal ApplyMetadataCascadePolicyRequestBody(StringEnum<ApplyMetadataCascadePolicyRequestBodyConflictResolutionField> conflictResolution) {
            ConflictResolution = conflictResolution;
        }
    }
}