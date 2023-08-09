using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClassificationTemplateFieldsFieldOptionsFieldStaticConfigField {
        [JsonPropertyName("classification")]
        public ClassificationTemplateFieldsFieldOptionsFieldStaticConfigFieldClassificationField Classification { get; }

        public ClassificationTemplateFieldsFieldOptionsFieldStaticConfigField(ClassificationTemplateFieldsFieldOptionsFieldStaticConfigFieldClassificationField classification) {
            Classification = classification;
        }
    }
}