using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderWatermarkRequestBodyArgWatermarkField {
        /// <summary>
        /// The type of watermark to apply.
        /// 
        /// Currently only supports one option.
        /// </summary>
        [JsonPropertyName("imprint")]
        public UpdateFolderWatermarkRequestBodyArgWatermarkFieldImprintField Imprint { get; set; }

        public UpdateFolderWatermarkRequestBodyArgWatermarkField(UpdateFolderWatermarkRequestBodyArgWatermarkFieldImprintField imprint) {
            Imprint = imprint;
        }
    }
}