using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataQueryIndicesQueryParamsArg {
        public GetMetadataQueryIndicesQueryParamsArgScopeField Scope { get; }

        public string TemplateKey { get; }

        public GetMetadataQueryIndicesQueryParamsArg(GetMetadataQueryIndicesQueryParamsArgScopeField scope, string templateKey) {
            Scope = scope;
            TemplateKey = templateKey;
        }
    }
}