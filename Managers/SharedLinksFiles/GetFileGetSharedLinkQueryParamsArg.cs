using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileGetSharedLinkQueryParamsArg {
        public string Fields { get; }

        public GetFileGetSharedLinkQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}