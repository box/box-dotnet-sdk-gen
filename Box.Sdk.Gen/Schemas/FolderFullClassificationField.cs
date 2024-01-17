using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FolderFullClassificationField {
        /// <summary>
        /// The name of the classification
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// An explanation of the meaning of this classification.
        /// </summary>
        [JsonPropertyName("definition")]
        public string? Definition { get; set; } = default;

        /// <summary>
        /// The color that is used to display the
        /// classification label in a user-interface. Colors are defined by the admin
        /// or co-admin who created the classification in the Box web app.
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get; set; } = default;

        public FolderFullClassificationField() {
            
        }
    }
}