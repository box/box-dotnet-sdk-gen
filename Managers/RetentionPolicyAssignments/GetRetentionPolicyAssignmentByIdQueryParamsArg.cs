using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRetentionPolicyAssignmentByIdQueryParamsArg {
        public string Fields { get; }

        public GetRetentionPolicyAssignmentByIdQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}