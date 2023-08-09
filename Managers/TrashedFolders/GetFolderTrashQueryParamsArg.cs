using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderTrashQueryParamsArg {
        public string Fields { get; }

        public GetFolderTrashQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}