using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetEventsWithLongPollingHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetEventsWithLongPollingHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}