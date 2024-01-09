using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateRequestBodyFieldsField {
        /// <summary>
        /// The type of field. The basic fields are a `string` field for text, a
        /// `float` field for numbers, and a `date` fields to present the user with a
        /// date-time picker.
        /// 
        /// Additionally, metadata templates support an `enum` field for a basic list
        /// of items, and ` multiSelect` field for a similar list of items where the
        /// user can select more than one value.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateMetadataTemplateRequestBodyFieldsTypeField Type { get; set; }

        /// <summary>
        /// A unique identifier for the field. The identifier must
        /// be unique within the template to which it belongs.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// The display name of the field as it is shown to the user in the web and
        /// mobile apps.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// A description of the field. This is not shown to the user.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// Whether this field is hidden in the UI for the user and can only be set
        /// through the API instead.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; } = default;

        /// <summary>
        /// A list of options for this field. This is used in combination with the
        /// `enum` and `multiSelect` field types.
        /// </summary>
        [JsonPropertyName("options")]
        public IReadOnlyList<CreateMetadataTemplateRequestBodyFieldsOptionsField>? Options { get; set; } = default;

        public CreateMetadataTemplateRequestBodyFieldsField(CreateMetadataTemplateRequestBodyFieldsTypeField type, string key, string displayName) {
            Type = type;
            Key = key;
            DisplayName = displayName;
        }
    }
}