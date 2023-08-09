using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollectionItemsQueryParamsArg {
        public string Fields { get; }

        public int? Offset { get; }

        public int? Limit { get; }

        public GetCollectionItemsQueryParamsArg(string fields, int? offset, int? limit) {
            Fields = fields;
            Offset = offset;
            Limit = limit;
        }
    }
}