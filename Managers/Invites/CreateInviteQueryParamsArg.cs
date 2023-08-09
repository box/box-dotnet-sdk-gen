using System.IO;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateInviteQueryParamsArg {
        public string Fields { get; }

        public CreateInviteQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}