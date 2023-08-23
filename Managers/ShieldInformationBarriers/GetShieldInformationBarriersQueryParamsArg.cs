using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetShieldInformationBarriersQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetShieldInformationBarriersQueryParamsArg(string marker, long? limit) {
            Marker = marker;
            Limit = limit;
        }
    }
}