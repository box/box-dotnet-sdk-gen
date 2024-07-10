using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateInviteRequestBodyEnterpriseField {
        /// <summary>
        /// The ID of the enterprise
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateInviteRequestBodyEnterpriseField(string id) {
            Id = id;
        }
    }
}