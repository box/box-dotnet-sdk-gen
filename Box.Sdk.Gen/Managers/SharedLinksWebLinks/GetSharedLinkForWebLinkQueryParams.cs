using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class GetSharedLinkForWebLinkQueryParams {
        /// <summary>
        /// Explicitly request the `shared_link` fields
        /// to be returned for this item.
        /// </summary>
        public string Fields { get; }

        public GetSharedLinkForWebLinkQueryParams(string fields) {
            Fields = fields;
        }
    }
}