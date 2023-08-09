using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupQueryParamsArg {
        public string Fields { get; }

        public CreateGroupQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}