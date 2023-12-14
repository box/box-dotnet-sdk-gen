using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataQueryIndicesQueryParams {
        /// <summary>
        /// The scope of the metadata template
        /// </summary>
        public GetMetadataQueryIndicesQueryParamsScopeField Scope { get; set; }

        /// <summary>
        /// The name of the metadata template
        /// </summary>
        public string TemplateKey { get; set; }

        public GetMetadataQueryIndicesQueryParams(GetMetadataQueryIndicesQueryParamsScopeField scope, string templateKey) {
            Scope = scope;
            TemplateKey = templateKey;
        }
    }
}