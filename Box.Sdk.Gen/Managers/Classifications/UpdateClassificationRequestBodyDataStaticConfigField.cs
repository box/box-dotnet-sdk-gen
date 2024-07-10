using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateClassificationRequestBodyDataStaticConfigField {
        /// <summary>
        /// Additional details for the classification.
        /// </summary>
        [JsonPropertyName("classification")]
        public UpdateClassificationRequestBodyDataStaticConfigClassificationField? Classification { get; init; }

        public UpdateClassificationRequestBodyDataStaticConfigField() {
            
        }
    }
}