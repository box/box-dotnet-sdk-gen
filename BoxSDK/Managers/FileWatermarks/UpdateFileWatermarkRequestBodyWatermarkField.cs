using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileWatermarkRequestBodyWatermarkField {
        /// <summary>
        /// The type of watermark to apply.
        /// 
        /// Currently only supports one option.
        /// </summary>
        [JsonPropertyName("imprint")]
        public UpdateFileWatermarkRequestBodyWatermarkImprintField Imprint { get; set; }

        public UpdateFileWatermarkRequestBodyWatermarkField(UpdateFileWatermarkRequestBodyWatermarkImprintField imprint) {
            Imprint = imprint;
        }
    }
}