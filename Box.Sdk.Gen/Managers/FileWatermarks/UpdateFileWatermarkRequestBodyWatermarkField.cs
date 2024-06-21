using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileWatermarkRequestBodyWatermarkField {
        /// <summary>
        /// The type of watermark to apply.
        /// 
        /// Currently only supports one option.
        /// </summary>
        [JsonPropertyName("imprint")]
        [JsonConverter(typeof(StringEnumConverter<UpdateFileWatermarkRequestBodyWatermarkImprintField>))]
        public StringEnum<UpdateFileWatermarkRequestBodyWatermarkImprintField> Imprint { get; }

        public UpdateFileWatermarkRequestBodyWatermarkField(UpdateFileWatermarkRequestBodyWatermarkImprintField imprint = UpdateFileWatermarkRequestBodyWatermarkImprintField.Default) {
            Imprint = imprint;
        }
        
        [JsonConstructorAttribute]
        internal UpdateFileWatermarkRequestBodyWatermarkField(StringEnum<UpdateFileWatermarkRequestBodyWatermarkImprintField> imprint) {
            Imprint = UpdateFileWatermarkRequestBodyWatermarkImprintField.Default;
        }
    }
}