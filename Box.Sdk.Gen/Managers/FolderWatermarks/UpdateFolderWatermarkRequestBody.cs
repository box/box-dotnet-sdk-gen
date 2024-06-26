using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
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