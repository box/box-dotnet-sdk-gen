using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetCollectionItemsQueryParamsArg {
        public string Fields { get; }

        public long? Offset { get; }

        public long? Limit { get; }

        public GetCollectionItemsQueryParamsArg(string fields, long? offset, long? limit) {
            Fields = fields;
            Offset = offset;
            Limit = limit;
        }
    }
}