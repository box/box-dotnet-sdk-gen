using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetWebLinkGetSharedLinkQueryParamsArg {
        public string Fields { get; }

        public GetWebLinkGetSharedLinkQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}