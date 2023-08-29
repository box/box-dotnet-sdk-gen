using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataQueryIndicesQueryParamsArg {
        /// <summary>
        /// The scope of the metadata template
        /// </summary>
        public GetMetadataQueryIndicesQueryParamsArgScopeField Scope { get; set; }

        /// <summary>
        /// The name of the metadata template
        /// </summary>
        public string TemplateKey { get; set; }

        public GetMetadataQueryIndicesQueryParamsArg(GetMetadataQueryIndicesQueryParamsArgScopeField scope, string templateKey) {
            Scope = scope;
            TemplateKey = templateKey;
        }
    }
}