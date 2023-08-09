using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetInviteByIdQueryParamsArg {
        public string Fields { get; }

        public GetInviteByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}