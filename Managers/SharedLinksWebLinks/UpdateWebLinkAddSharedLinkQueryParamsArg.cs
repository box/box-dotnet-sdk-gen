using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkAddSharedLinkQueryParamsArg {
        public string Fields { get; }

        public UpdateWebLinkAddSharedLinkQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}