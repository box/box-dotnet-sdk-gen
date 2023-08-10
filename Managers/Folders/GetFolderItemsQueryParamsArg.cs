using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderItemsQueryParamsArg {
        public string Fields { get; }

        public bool? Usemarker { get; }

        public string Marker { get; }

        public int? Offset { get; }

        public int? Limit { get; }

        public GetFolderItemsQueryParamsArgSortField Sort { get; }

        public GetFolderItemsQueryParamsArgDirectionField Direction { get; }

        public GetFolderItemsQueryParamsArg(string fields, bool? usemarker, string marker, int? offset, int? limit, GetFolderItemsQueryParamsArgSortField sort, GetFolderItemsQueryParamsArgDirectionField direction) {
            Fields = fields;
            Usemarker = usemarker;
            Marker = marker;
            Offset = offset;
            Limit = limit;
            Sort = sort;
            Direction = direction;
        }
    }
}