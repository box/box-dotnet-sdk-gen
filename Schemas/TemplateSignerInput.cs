using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TemplateSignerInput : SignRequestPrefillTag {
        [JsonPropertyName("type")]
        public TemplateSignerInputTypeField Type { get; }

        [JsonPropertyName("content_type")]
        public TemplateSignerInputContentTypeField ContentType { get; }

        [JsonPropertyName("is_required")]
        public bool? IsRequired { get; }

        [JsonPropertyName("page_index")]
        public int PageIndex { get; }

        [JsonPropertyName("document_id")]
        public string DocumentId { get; }

        [JsonPropertyName("dropdown_choices")]
        public IReadOnlyList<string> DropdownChoices { get; }

        [JsonPropertyName("group_id")]
        public string GroupId { get; }

        [JsonPropertyName("coordinates")]
        public TemplateSignerInputCoordinatesField Coordinates { get; }

        [JsonPropertyName("dimensions")]
        public TemplateSignerInputDimensionsField Dimensions { get; }

        public TemplateSignerInput(string documentTagId, string textValue, bool? checkboxValue, string dateValue, TemplateSignerInputTypeField type, TemplateSignerInputContentTypeField contentType, bool? isRequired, int pageIndex, string documentId, IReadOnlyList<string> dropdownChoices, string groupId, TemplateSignerInputCoordinatesField coordinates, TemplateSignerInputDimensionsField dimensions) : base(documentTagId, textValue, checkboxValue, dateValue) {
            Type = type;
            ContentType = contentType;
            IsRequired = isRequired;
            PageIndex = pageIndex;
            DocumentId = documentId;
            DropdownChoices = dropdownChoices;
            GroupId = groupId;
            Coordinates = coordinates;
            Dimensions = dimensions;
        }
    }
}