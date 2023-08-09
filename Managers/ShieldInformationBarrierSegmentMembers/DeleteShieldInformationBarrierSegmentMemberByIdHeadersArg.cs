using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteShieldInformationBarrierSegmentMemberByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public DeleteShieldInformationBarrierSegmentMemberByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}