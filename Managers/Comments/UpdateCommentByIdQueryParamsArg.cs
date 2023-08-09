using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateCommentByIdQueryParamsArg {
        public string Fields { get; }

        public UpdateCommentByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}