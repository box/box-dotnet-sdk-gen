using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileTrashQueryParamsArg {
        public string Fields { get; }

        public GetFileTrashQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}