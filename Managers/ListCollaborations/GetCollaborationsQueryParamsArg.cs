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

        public int? Offset { get; }

        public int? Limit { get; }

        public GetCollaborationsQueryParamsArg(GetCollaborationsQueryParamsArgStatusField status, string fields, int? offset, int? limit) {
            Status = status;
            Fields = fields;
            Offset = offset;
            Limit = limit;
        }
    }
}