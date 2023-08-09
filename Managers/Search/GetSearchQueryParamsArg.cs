using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSearchQueryParamsArg {
        public string Query { get; }

        public GetSearchQueryParamsArgScopeField Scope { get; }

        public string FileExtensions { get; }

        public string CreatedAtRange { get; }

        public string UpdatedAtRange { get; }

        public string SizeRange { get; }

        public string OwnerUserIds { get; }

        public string RecentUpdaterUserIds { get; }

        public string AncestorFolderIds { get; }

        public string ContentTypes { get; }

        public GetSearchQueryParamsArgTypeField Type { get; }

        public GetSearchQueryParamsArgTrashContentField TrashContent { get; }

        public string Mdfilters { get; }

        public GetSearchQueryParamsArgSortField Sort { get; }

        public GetSearchQueryParamsArgDirectionField Direction { get; }

        public int? Limit { get; }

        public bool? IncludeRecentSharedLinks { get; }

        public string Fields { get; }

        public int? Offset { get; }

        public string DeletedUserIds { get; }

        public string DeletedAtRange { get; }

        public GetSearchQueryParamsArg(string query, GetSearchQueryParamsArgScopeField scope, string fileExtensions, string createdAtRange, string updatedAtRange, string sizeRange, string ownerUserIds, string recentUpdaterUserIds, string ancestorFolderIds, string contentTypes, GetSearchQueryParamsArgTypeField type, GetSearchQueryParamsArgTrashContentField trashContent, string mdfilters, GetSearchQueryParamsArgSortField sort, GetSearchQueryParamsArgDirectionField direction, int? limit, bool? includeRecentSharedLinks, string fields, int? offset, string deletedUserIds, string deletedAtRange) {
            Query = query;
            Scope = scope;
            FileExtensions = fileExtensions;
            CreatedAtRange = createdAtRange;
            UpdatedAtRange = updatedAtRange;
            SizeRange = sizeRange;
            OwnerUserIds = ownerUserIds;
            RecentUpdaterUserIds = recentUpdaterUserIds;
            AncestorFolderIds = ancestorFolderIds;
            ContentTypes = contentTypes;
            Type = type;
            TrashContent = trashContent;
            Mdfilters = mdfilters;
            Sort = sort;
            Direction = direction;
            Limit = limit;
            IncludeRecentSharedLinks = includeRecentSharedLinks;
            Fields = fields;
            Offset = offset;
            DeletedUserIds = deletedUserIds;
            DeletedAtRange = deletedAtRange;
        }
    }
}