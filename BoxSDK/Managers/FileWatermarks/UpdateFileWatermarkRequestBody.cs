using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileWatermarkRequestBody {
        /// <summary>
        /// The watermark to imprint on the file
        /// </summary>
        [JsonPropertyName("watermark")]
        public UpdateFileWatermarkRequestBodyWatermarkField Watermark { get; set; }

        public UpdateFileWatermarkRequestBody(UpdateFileWatermarkRequestBodyWatermarkField watermark) {
            Watermark = watermark;
        }
    }
}