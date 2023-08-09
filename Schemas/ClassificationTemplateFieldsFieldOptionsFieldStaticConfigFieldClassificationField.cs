using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClassificationTemplateFieldsFieldOptionsFieldStaticConfigFieldClassificationField {
        [JsonPropertyName("classificationDefinition")]
        public string ClassificationDefinition { get; }

        [JsonPropertyName("colorID")]
        public int? ColorId { get; }

        public ClassificationTemplateFieldsFieldOptionsFieldStaticConfigFieldClassificationField(string classificationDefinition, int? colorId) {
            ClassificationDefinition = classificationDefinition;
            ColorId = colorId;
        }
    }
}