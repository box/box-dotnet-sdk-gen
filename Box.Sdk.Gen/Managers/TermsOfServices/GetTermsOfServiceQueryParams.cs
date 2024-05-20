using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class GetTermsOfServiceQueryParams {
        /// <summary>
        /// Limits the results to the terms of service of the given type.
        /// </summary>
        public GetTermsOfServiceQueryParamsTosTypeField? TosType { get; init; }

        public GetTermsOfServiceQueryParams() {
            
        }
    }
}