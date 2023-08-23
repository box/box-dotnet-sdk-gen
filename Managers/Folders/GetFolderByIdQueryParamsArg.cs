using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderByIdQueryParamsArg {
        public string Fields { get; }

        public GetFolderByIdQueryParamsArgSortField Sort { get; }

        public GetFolderByIdQueryParamsArgDirectionField Direction { get; }

        public long? Offset { get; }

        public long? Limit { get; }

        public GetFolderByIdQueryParamsArg(string fields, GetFolderByIdQueryParamsArgSortField sort, GetFolderByIdQueryParamsArgDirectionField direction, long? offset, long? limit) {
            Fields = fields;
            Sort = sort;
            Direction = direction;
            Offset = offset;
            Limit = limit;
        }
    }
}