using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RestoreFileFromTrashQueryParamsArg {
        public string Fields { get; }

        public RestoreFileFromTrashQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}