using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsFieldStaticConfigFieldClassificationField {
        /// <summary>
        /// A longer description of the classification.
        /// </summary>
        [JsonPropertyName("classificationDefinition")]
        public string? ClassificationDefinition { get; set; } = default;

        /// <summary>
        /// An identifier used to assign a color to
        /// a classification label.
        /// 
        /// Mapping between a `colorID` and a color may
        /// change without notice. Currently, the color
        /// mappings are as follows.
        /// 
        /// * `0`: Yellow
        /// * `1`: Orange
        /// * `2`: Watermelon red
        /// * `3`: Purple rain
        /// * `4`: Light blue
        /// * `5`: Dark blue
        /// * `6`: Light green
        /// * `7`: Gray
        /// </summary>
        [JsonPropertyName("colorID")]
        public long? ColorId { get; set; } = default;

        public CreateMetadataTemplateSchemaClassificationRequestBodyArgFieldsFieldOptionsFieldStaticConfigFieldClassificationField() {
            
        }
    }
}