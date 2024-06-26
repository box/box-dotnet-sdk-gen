using Unions;
using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class GetTermsOfServiceQueryParams {
        /// <summary>
        /// Limits the results to the terms of service of the given type.
        /// </summary>
        public StringEnum<GetTermsOfServiceQueryParamsTosTypeField>? TosType { get; init; }

        public GetTermsOfServiceQueryParams() {
            
        }
    }
}