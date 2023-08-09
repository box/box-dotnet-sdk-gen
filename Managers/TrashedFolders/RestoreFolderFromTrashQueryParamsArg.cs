using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RestoreFolderFromTrashQueryParamsArg {
        public string Fields { get; }

        public RestoreFolderFromTrashQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}