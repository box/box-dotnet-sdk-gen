using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class GetMetadataTemplatesByInstanceIdQueryParams {
        /// <summary>
        /// The ID of an instance of the metadata template to find.
        /// </summary>
        public string MetadataInstanceId { get; set; }

        public GetMetadataTemplatesByInstanceIdQueryParams(string metadataInstanceId) {
            MetadataInstanceId = metadataInstanceId;
        }
    }
}