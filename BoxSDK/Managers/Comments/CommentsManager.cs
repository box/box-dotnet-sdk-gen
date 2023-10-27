using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CommentsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public CommentsManager() {
            
        }
        /// <summary>
        /// Retrieves a list of comments for a file.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier that represents a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getFileComments method
        /// </param>
        /// <param name="headers">
        /// Headers of getFileComments method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Comments> GetFileCommentsAsync(string fileId, GetFileCommentsQueryParamsArg? queryParams = default, GetFileCommentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetFileCommentsQueryParamsArg();
            headers = headers ?? new GetFileCommentsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/comments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Comments>(response.Text);
        }

        /// <summary>
        /// Retrieves the message and metadata for a specific comment, as well
        /// as information on the user who created the comment.
        /// </summary>
        /// <param name="commentId">
        /// The ID of the comment.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getCommentById method
        /// </param>
        /// <param name="headers">
        /// Headers of getCommentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<CommentFull> GetCommentByIdAsync(string commentId, GetCommentByIdQueryParamsArg? queryParams = default, GetCommentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetCommentByIdQueryParamsArg();
            headers = headers ?? new GetCommentByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/comments/", StringUtils.ToStringRepresentation(commentId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<CommentFull>(response.Text);
        }

        /// <summary>
        /// Update the message of a comment.
        /// </summary>
        /// <param name="commentId">
        /// The ID of the comment.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateCommentById method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of updateCommentById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateCommentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<CommentFull> UpdateCommentByIdAsync(string commentId, UpdateCommentByIdRequestBodyArg? requestBody = default, UpdateCommentByIdQueryParamsArg? queryParams = default, UpdateCommentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateCommentByIdRequestBodyArg();
            queryParams = queryParams ?? new UpdateCommentByIdQueryParamsArg();
            headers = headers ?? new UpdateCommentByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/comments/", StringUtils.ToStringRepresentation(commentId)), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<CommentFull>(response.Text);
        }

        /// <summary>
        /// Permanently deletes a comment.
        /// </summary>
        /// <param name="commentId">
        /// The ID of the comment.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteCommentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteCommentByIdAsync(string commentId, DeleteCommentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteCommentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/comments/", StringUtils.ToStringRepresentation(commentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds a comment by the user to a specific file, or
        /// as a reply to an other comment.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createComment method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of createComment method
        /// </param>
        /// <param name="headers">
        /// Headers of createComment method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Comment> CreateCommentAsync(CreateCommentRequestBodyArg requestBody, CreateCommentQueryParamsArg? queryParams = default, CreateCommentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new CreateCommentQueryParamsArg();
            headers = headers ?? new CreateCommentHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/comments"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Comment>(response.Text);
        }

    }
}