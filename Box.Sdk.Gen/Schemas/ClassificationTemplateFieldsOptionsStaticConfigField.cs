using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class ClassificationTemplateFieldsOptionsStaticConfigField {
        /// <summary>
        /// Additional information about the classification.
        /// 
        /// This is not an exclusive list of properties, and
        /// more object fields might be returned. These fields
        /// are used for internal Box Shield and Box Governance
        /// purposes and no additional value must be derived from
        /// these fields.
        /// </summary>
        [JsonPropertyName("classification")]
        public ClassificationTemplateFieldsOptionsStaticConfigClassificationField? Classification { get; set; } = default;

        public ClassificationTemplateFieldsOptionsStaticConfigField() {
            
        }
    }
}