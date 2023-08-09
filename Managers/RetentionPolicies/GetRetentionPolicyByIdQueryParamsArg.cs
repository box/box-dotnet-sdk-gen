using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRetentionPolicyByIdQueryParamsArg {
        public string Fields { get; }

        public GetRetentionPolicyByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}