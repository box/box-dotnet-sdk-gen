using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkByIdRequestBodyArgParentField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public UpdateWebLinkByIdRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}