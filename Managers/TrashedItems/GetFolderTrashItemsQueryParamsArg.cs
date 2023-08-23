using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderTrashItemsQueryParamsArg {
        public string Fields { get; }

        public long? Limit { get; }

        public long? Offset { get; }

        public bool? Usemarker { get; }

        public string Marker { get; }

        public GetFolderTrashItemsQueryParamsArgDirectionField Direction { get; }

        public GetFolderTrashItemsQueryParamsArgSortField Sort { get; }

        public GetFolderTrashItemsQueryParamsArg(string fields, long? limit, long? offset, bool? usemarker, string marker, GetFolderTrashItemsQueryParamsArgDirectionField direction, GetFolderTrashItemsQueryParamsArgSortField sort) {
            Fields = fields;
            Limit = limit;
            Offset = offset;
            Usemarker = usemarker;
            Marker = marker;
            Direction = direction;
            Sort = sort;
        }
    }
}