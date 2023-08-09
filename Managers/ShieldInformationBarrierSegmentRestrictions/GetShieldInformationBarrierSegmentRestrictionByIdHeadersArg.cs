using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetShieldInformationBarrierSegmentRestrictionByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetShieldInformationBarrierSegmentRestrictionByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}