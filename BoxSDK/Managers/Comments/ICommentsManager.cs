using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ICommentsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Comments> GetFileCommentsAsync(string fileId, GetFileCommentsQueryParams? queryParams = default, GetFileCommentsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CommentFull> GetCommentByIdAsync(string commentId, GetCommentByIdQueryParams? queryParams = default, GetCommentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CommentFull> UpdateCommentByIdAsync(string commentId, UpdateCommentByIdRequestBody? requestBody = default, UpdateCommentByIdQueryParams? queryParams = default, UpdateCommentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCommentByIdAsync(string commentId, DeleteCommentByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CommentFull> CreateCommentAsync(CreateCommentRequestBody requestBody, CreateCommentQueryParams? queryParams = default, CreateCommentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}