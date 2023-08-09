using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderCollaborationsQueryParamsArg {
        public string Fields { get; }

        public GetFolderCollaborationsQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}