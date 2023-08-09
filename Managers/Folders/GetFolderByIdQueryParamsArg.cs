using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderByIdQueryParamsArg {
        public string Fields { get; }

        public GetFolderByIdQueryParamsArgSortField Sort { get; }

        public GetFolderByIdQueryParamsArgDirectionField Direction { get; }

        public int? Offset { get; }

        public int? Limit { get; }

        public GetFolderByIdQueryParamsArg(string fields, GetFolderByIdQueryParamsArgSortField sort, GetFolderByIdQueryParamsArgDirectionField direction, int? offset, int? limit) {
            Fields = fields;
            Sort = sort;
            Direction = direction;
            Offset = offset;
            Limit = limit;
        }
    }
}