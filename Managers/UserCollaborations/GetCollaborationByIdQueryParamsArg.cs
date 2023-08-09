using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollaborationByIdQueryParamsArg {
        public string Fields { get; }

        public GetCollaborationByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}