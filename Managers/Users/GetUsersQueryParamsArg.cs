using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetUsersQueryParamsArg {
        public string FilterTerm { get; }

        public GetUsersQueryParamsArgUserTypeField UserType { get; }

        public string ExternalAppUserId { get; }

        public string Fields { get; }

        public long? Offset { get; }

        public long? Limit { get; }

        public bool? Usemarker { get; }

        public string Marker { get; }

        public GetUsersQueryParamsArg(string filterTerm, GetUsersQueryParamsArgUserTypeField userType, string externalAppUserId, string fields, long? offset, long? limit, bool? usemarker, string marker) {
            FilterTerm = filterTerm;
            UserType = userType;
            ExternalAppUserId = externalAppUserId;
            Fields = fields;
            Offset = offset;
            Limit = limit;
            Usemarker = usemarker;
            Marker = marker;
        }
    }
}