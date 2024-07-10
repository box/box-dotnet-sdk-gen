using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class GetMetadataTemplatesByInstanceIdQueryParams {
        /// <summary>
        /// The ID of an instance of the metadata template to find.
        /// </summary>
        public string MetadataInstanceId { get; }

        public GetMetadataTemplatesByInstanceIdQueryParams(string metadataInstanceId) {
            MetadataInstanceId = metadataInstanceId;
        }
    }
}