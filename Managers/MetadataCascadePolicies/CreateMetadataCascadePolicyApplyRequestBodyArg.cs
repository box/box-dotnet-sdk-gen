using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataCascadePolicyApplyRequestBodyArg {
        [JsonPropertyName("conflict_resolution")]
        public CreateMetadataCascadePolicyApplyRequestBodyArgConflictResolutionField ConflictResolution { get; }

        public CreateMetadataCascadePolicyApplyRequestBodyArg(CreateMetadataCascadePolicyApplyRequestBodyArgConflictResolutionField conflictResolution) {
            ConflictResolution = conflictResolution;
        }
    }
}