using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderWatermarkRequestBodyWatermarkField {
        /// <summary>
        /// The type of watermark to apply.
        /// 
        /// Currently only supports one option.
        /// </summary>
        [JsonPropertyName("imprint")]
        public UpdateFolderWatermarkRequestBodyWatermarkImprintField Imprint { get; set; }

        public UpdateFolderWatermarkRequestBodyWatermarkField(UpdateFolderWatermarkRequestBodyWatermarkImprintField imprint) {
            Imprint = imprint;
        }
    }
}