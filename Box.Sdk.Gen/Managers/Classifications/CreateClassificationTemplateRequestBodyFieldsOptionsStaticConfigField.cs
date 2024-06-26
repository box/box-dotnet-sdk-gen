using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using System;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateClassificationTemplateRequestBodyFieldsOptionsStaticConfigField {
        /// <summary>
        /// Additional information about the classification.
        /// </summary>
        [JsonPropertyName("classification")]
        public CreateClassificationTemplateRequestBodyFieldsOptionsStaticConfigClassificationField? Classification { get; init; }

        public CreateClassificationTemplateRequestBodyFieldsOptionsStaticConfigField() {
            
        }
    }
}