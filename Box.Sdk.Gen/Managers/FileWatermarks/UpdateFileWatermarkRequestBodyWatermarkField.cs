using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileWatermarkRequestBodyWatermarkField {
        /// <summary>
        /// The type of watermark to apply.
        /// 
        /// Currently only supports one option.
        /// </summary>
        [JsonPropertyName("imprint")]
        public UpdateFileWatermarkRequestBodyWatermarkImprintField Imprint { get; }

        public UpdateFileWatermarkRequestBodyWatermarkField(UpdateFileWatermarkRequestBodyWatermarkImprintField imprint = UpdateFileWatermarkRequestBodyWatermarkImprintField.Default) {
            Imprint = imprint;
        }
    }
}