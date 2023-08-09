using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSharedItemsQueryParamsArg {
        public string Fields { get; }

        public GetSharedItemsQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}