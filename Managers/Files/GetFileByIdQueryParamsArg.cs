using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileByIdQueryParamsArg {
        public string Fields { get; }

        public GetFileByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}