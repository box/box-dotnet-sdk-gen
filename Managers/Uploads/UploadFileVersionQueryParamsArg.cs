using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileVersionQueryParamsArg {
        public string Fields { get; }

        public UploadFileVersionQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}