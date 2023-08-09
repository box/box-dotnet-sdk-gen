using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWebLinkByIdQueryParamsArg {
        public string Fields { get; }

        public CreateWebLinkByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}