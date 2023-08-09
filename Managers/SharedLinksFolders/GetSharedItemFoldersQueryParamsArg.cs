using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSharedItemFoldersQueryParamsArg {
        public string Fields { get; }

        public GetSharedItemFoldersQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}