using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetTermOfServicesQueryParamsArg {
        /// <summary>
        /// Limits the results to the terms of service of the given type.
        /// </summary>
        public GetTermOfServicesQueryParamsArgTosTypeField? TosType { get; set; } = default;

        public GetTermOfServicesQueryParamsArg() {
            
        }
    }
}