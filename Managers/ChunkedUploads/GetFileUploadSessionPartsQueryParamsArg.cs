using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileUploadSessionPartsQueryParamsArg {
        public long? Offset { get; }

        public long? Limit { get; }

        public GetFileUploadSessionPartsQueryParamsArg(long? offset, long? limit) {
            Offset = offset;
            Limit = limit;
        }
    }
}