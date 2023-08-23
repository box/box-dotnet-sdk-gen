using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollaborationsQueryParamsArg {
        public GetCollaborationsQueryParamsArgStatusField Status { get; }

        public string Fields { get; }

        public long? Offset { get; }

        public long? Limit { get; }

        public GetCollaborationsQueryParamsArg(GetCollaborationsQueryParamsArgStatusField status, string fields, long? offset, long? limit) {
            Status = status;
            Fields = fields;
            Offset = offset;
            Limit = limit;
        }
    }
}