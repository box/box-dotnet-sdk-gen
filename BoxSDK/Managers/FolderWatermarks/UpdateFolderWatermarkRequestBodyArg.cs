using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderWatermarkRequestBodyArg {
        /// <summary>
        /// The watermark to imprint on the folder
        /// </summary>
        [JsonPropertyName("watermark")]
        public UpdateFolderWatermarkRequestBodyArgWatermarkField Watermark { get; set; }

        public UpdateFolderWatermarkRequestBodyArg(UpdateFolderWatermarkRequestBodyArgWatermarkField watermark) {
            Watermark = watermark;
        }
    }
}