using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class StatusSkillCardSkillField : ISerializable {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<StatusSkillCardSkillTypeField>))]
        public StringEnum<StatusSkillCardSkillTypeField> Type { get; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public StatusSkillCardSkillField(string id, StatusSkillCardSkillTypeField type = StatusSkillCardSkillTypeField.Service) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal StatusSkillCardSkillField(string id, StringEnum<StatusSkillCardSkillTypeField> type) {
            Type = StatusSkillCardSkillTypeField.Service;
            Id = id;
        }
        internal string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}