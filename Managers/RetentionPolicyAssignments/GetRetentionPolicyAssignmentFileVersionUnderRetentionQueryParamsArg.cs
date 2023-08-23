using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetRetentionPolicyAssignmentFileVersionUnderRetentionQueryParamsArg(string marker, long? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}