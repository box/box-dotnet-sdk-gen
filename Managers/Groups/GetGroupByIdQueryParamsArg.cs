using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetGroupByIdQueryParamsArg {
        public string Fields { get; }

        public GetGroupByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}