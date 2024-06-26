using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class CollaboratorVariableVariableValueField {
        /// <summary>
        /// The object type.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CollaboratorVariableVariableValueTypeField>))]
        public StringEnum<CollaboratorVariableVariableValueTypeField> Type { get; }

        /// <summary>
        /// User's ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CollaboratorVariableVariableValueField(string id, CollaboratorVariableVariableValueTypeField type = CollaboratorVariableVariableValueTypeField.User) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal CollaboratorVariableVariableValueField(string id, StringEnum<CollaboratorVariableVariableValueTypeField> type) {
            Type = CollaboratorVariableVariableValueTypeField.User;
            Id = id;
        }
    }
}