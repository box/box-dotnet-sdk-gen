using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSignRequestsQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetSignRequestsQueryParamsArg(string marker, long? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}