using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileRemoveSharedLinkQueryParamsArg {
        public string Fields { get; }

        public UpdateFileRemoveSharedLinkQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}