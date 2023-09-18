using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileWatermarkRequestBodyArgWatermarkField {
        /// <summary>
        /// The type of watermark to apply.
        /// 
        /// Currently only supports one option.
        /// </summary>
        [JsonPropertyName("imprint")]
        public UpdateFileWatermarkRequestBodyArgWatermarkFieldImprintField Imprint { get; set; }

        public UpdateFileWatermarkRequestBodyArgWatermarkField(UpdateFileWatermarkRequestBodyArgWatermarkFieldImprintField imprint) {
            Imprint = imprint;
        }
    }
}