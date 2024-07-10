using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileWatermarkRequestBody {
        /// <summary>
        /// The watermark to imprint on the file
        /// </summary>
        [JsonPropertyName("watermark")]
        public UpdateFileWatermarkRequestBodyWatermarkField Watermark { get; }

        public UpdateFileWatermarkRequestBody(UpdateFileWatermarkRequestBodyWatermarkField watermark) {
            Watermark = watermark;
        }
    }
}