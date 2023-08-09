using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileVersionByIdQueryParamsArg {
        public string Fields { get; }

        public GetFileVersionByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}