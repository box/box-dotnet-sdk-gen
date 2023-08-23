using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetEnterpriseDevicePinnersQueryParamsArg {
        public string Marker { get; }

        public long? Limit { get; }

        public GetEnterpriseDevicePinnersQueryParamsArgDirectionField Direction { get; }

        public GetEnterpriseDevicePinnersQueryParamsArg(string marker, long? limit, GetEnterpriseDevicePinnersQueryParamsArgDirectionField direction) {
            Marker = marker;
            Limit = limit;
            Direction = direction;
        }
    }
}