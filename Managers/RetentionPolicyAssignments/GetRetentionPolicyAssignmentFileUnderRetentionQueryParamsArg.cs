using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg {
        public string Marker { get; }

        public int? Limit { get; }

        public GetRetentionPolicyAssignmentFileUnderRetentionQueryParamsArg(string marker, int? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}