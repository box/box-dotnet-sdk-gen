using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateClassificationTemplateRequestBodyFieldsOptionsStaticConfigField {
        /// <summary>
        /// Additional information about the classification.
        /// </summary>
        [JsonPropertyName("classification")]
        public CreateClassificationTemplateRequestBodyFieldsOptionsStaticConfigClassificationField? Classification { get; set; } = default;

        public CreateClassificationTemplateRequestBodyFieldsOptionsStaticConfigField() {
            
        }
    }
}