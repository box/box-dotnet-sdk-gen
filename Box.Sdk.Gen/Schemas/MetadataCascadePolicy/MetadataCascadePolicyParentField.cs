using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataCascadePolicyParentField {
        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<MetadataCascadePolicyParentTypeField>))]
        public StringEnum<MetadataCascadePolicyParentTypeField>? Type { get; init; }

        /// <summary>
        /// The ID of the folder the policy is applied to.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public MetadataCascadePolicyParentField() {
            
        }
    }
}