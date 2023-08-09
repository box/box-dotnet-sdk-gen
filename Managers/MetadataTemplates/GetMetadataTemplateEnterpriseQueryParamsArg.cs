using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataTemplateEnterpriseQueryParamsArg {
        public string Marker { get; }

        public int? Limit { get; }

        public GetMetadataTemplateEnterpriseQueryParamsArg(string marker, int? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}