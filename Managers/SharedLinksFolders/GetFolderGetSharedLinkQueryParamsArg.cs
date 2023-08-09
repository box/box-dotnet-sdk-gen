using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderGetSharedLinkQueryParamsArg {
        public string Fields { get; }

        public GetFolderGetSharedLinkQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}