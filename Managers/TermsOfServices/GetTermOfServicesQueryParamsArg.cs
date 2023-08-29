using System.IO;
using Unions;
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