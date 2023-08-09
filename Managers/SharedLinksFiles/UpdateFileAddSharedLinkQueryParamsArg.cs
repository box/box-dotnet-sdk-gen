using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileAddSharedLinkQueryParamsArg {
        public string Fields { get; }

        public UpdateFileAddSharedLinkQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}