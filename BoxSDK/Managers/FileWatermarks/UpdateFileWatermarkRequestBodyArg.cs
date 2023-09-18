using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileWatermarkRequestBodyArg {
        /// <summary>
        /// The watermark to imprint on the file
        /// </summary>
        [JsonPropertyName("watermark")]
        public UpdateFileWatermarkRequestBodyArgWatermarkField Watermark { get; set; }

        public UpdateFileWatermarkRequestBodyArg(UpdateFileWatermarkRequestBodyArgWatermarkField watermark) {
            Watermark = watermark;
        }
    }
}