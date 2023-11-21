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

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Comments> GetFileCommentsAsync(string fileId, GetFileCommentsQueryParamsArg? queryParams = default, GetFileCommentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CommentFull> GetCommentByIdAsync(string commentId, GetCommentByIdQueryParamsArg? queryParams = default, GetCommentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CommentFull> UpdateCommentByIdAsync(string commentId, UpdateCommentByIdRequestBodyArg? requestBody = default, UpdateCommentByIdQueryParamsArg? queryParams = default, UpdateCommentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteCommentByIdAsync(string commentId, DeleteCommentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<CommentFull> CreateCommentAsync(CreateCommentRequestBodyArg requestBody, CreateCommentQueryParamsArg? queryParams = default, CreateCommentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}