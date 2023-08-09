using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetTermOfServicesQueryParamsArg {
        public GetTermOfServicesQueryParamsArgTosTypeField TosType { get; }

        public GetTermOfServicesQueryParamsArg(GetTermOfServicesQueryParamsArgTosTypeField tosType) {
            TosType = tosType;
        }
    }
}