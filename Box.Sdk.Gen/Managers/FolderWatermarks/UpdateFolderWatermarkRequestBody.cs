using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFolderWatermarkRequestBody {
        /// <summary>
        /// The watermark to imprint on the folder
        /// </summary>
        [JsonPropertyName("watermark")]
        public UpdateFolderWatermarkRequestBodyWatermarkField Watermark { get; }

        public UpdateFolderWatermarkRequestBody(UpdateFolderWatermarkRequestBodyWatermarkField watermark) {
            Watermark = watermark;
        }
    }
}