using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestSignerInput : SignRequestPrefillTag {
        [JsonPropertyName("type")]
        public SignRequestSignerInputTypeField Type { get; }

        [JsonPropertyName("content_type")]
        public SignRequestSignerInputContentTypeField ContentType { get; }

        [JsonPropertyName("page_index")]
        public int PageIndex { get; }

        public SignRequestSignerInput(string documentTagId, string textValue, bool? checkboxValue, string dateValue, SignRequestSignerInputTypeField type, SignRequestSignerInputContentTypeField contentType, int pageIndex) : base(documentTagId, textValue, checkboxValue, dateValue) {
            Type = type;
            ContentType = contentType;
            PageIndex = pageIndex;
        }
    }
}