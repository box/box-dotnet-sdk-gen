using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class CollaboratorVariableVariableValueField {
        /// <summary>
        /// The object type.
        /// </summary>
        [JsonPropertyName("type")]
        public CollaboratorVariableVariableValueTypeField Type { get; set; }

        /// <summary>
        /// User's ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CollaboratorVariableVariableValueField(string id, CollaboratorVariableVariableValueTypeField type = CollaboratorVariableVariableValueTypeField.User) {
            Type = type;
            Id = id;
        }
    }
}