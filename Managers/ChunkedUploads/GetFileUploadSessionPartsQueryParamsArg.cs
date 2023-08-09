using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileUploadSessionPartsQueryParamsArg {
        public int? Offset { get; }

        public int? Limit { get; }

        public GetFileUploadSessionPartsQueryParamsArg(int? offset, int? limit) {
            Offset = offset;
            Limit = limit;
        }
    }
}