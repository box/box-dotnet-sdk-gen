using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataTemplatesByInstanceIdQueryParamsArg {
        /// <summary>
        /// The ID of an instance of the metadata template to find.
        /// </summary>
        public string MetadataInstanceId { get; set; }

        public GetMetadataTemplatesByInstanceIdQueryParamsArg(string metadataInstanceId) {
            MetadataInstanceId = metadataInstanceId;
        }
    }
}