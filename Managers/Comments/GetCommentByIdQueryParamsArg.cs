using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCommentByIdQueryParamsArg {
        public string Fields { get; }

        public GetCommentByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}