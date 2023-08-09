using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSharedItemWebLinksQueryParamsArg {
        public string Fields { get; }

        public GetSharedItemWebLinksQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}