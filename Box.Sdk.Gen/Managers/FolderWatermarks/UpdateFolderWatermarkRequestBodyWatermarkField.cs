using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFolderWatermarkRequestBodyWatermarkField {
        /// <summary>
        /// The type of watermark to apply.
        /// 
        /// Currently only supports one option.
        /// </summary>
        [JsonPropertyName("imprint")]
        [JsonConverter(typeof(StringEnumConverter<UpdateFolderWatermarkRequestBodyWatermarkImprintField>))]
        public StringEnum<UpdateFolderWatermarkRequestBodyWatermarkImprintField> Imprint { get; }

        public UpdateFolderWatermarkRequestBodyWatermarkField(UpdateFolderWatermarkRequestBodyWatermarkImprintField imprint = UpdateFolderWatermarkRequestBodyWatermarkImprintField.Default) {
            Imprint = imprint;
        }
        
        [JsonConstructorAttribute]
        internal UpdateFolderWatermarkRequestBodyWatermarkField(StringEnum<UpdateFolderWatermarkRequestBodyWatermarkImprintField> imprint) {
            Imprint = UpdateFolderWatermarkRequestBodyWatermarkImprintField.Default;
        }
    }
}