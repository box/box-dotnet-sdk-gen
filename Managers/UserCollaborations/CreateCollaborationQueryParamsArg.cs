using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationQueryParamsArg {
        public string Fields { get; }

        public bool? Notify { get; }

        public CreateCollaborationQueryParamsArg(string fields, bool? notify) {
            Fields = fields;
            Notify = notify;
        }
    }
}