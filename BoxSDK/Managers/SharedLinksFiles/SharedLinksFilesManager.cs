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
    public class SharedLinksFilesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SharedLinksFilesManager() {
            
        }
        public async System.Threading.Tasks.Task<FileFull> GetSharedItems(GetSharedItemsHeadersArg headers, GetSharedItemsQueryParamsArg? queryParams = default) {
            queryParams = queryParams ?? new GetSharedItemsQueryParamsArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-none-match", StringUtils.ToStringRepresentation(headers.IfNoneMatch) }, { "boxapi", StringUtils.ToStringRepresentation(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shared_items"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileFull> GetFileGetSharedLink(string fileId, GetFileGetSharedLinkQueryParamsArg queryParams, GetFileGetSharedLinkHeadersArg? headers = default) {
            headers = headers ?? new GetFileGetSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "#get_shared_link"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileFull> UpdateFileAddSharedLink(string fileId, UpdateFileAddSharedLinkQueryParamsArg queryParams, UpdateFileAddSharedLinkRequestBodyArg? requestBody = default, UpdateFileAddSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFileAddSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFileAddSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "#add_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileFull> UpdateFileUpdateSharedLink(string fileId, UpdateFileUpdateSharedLinkQueryParamsArg queryParams, UpdateFileUpdateSharedLinkRequestBodyArg? requestBody = default, UpdateFileUpdateSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFileUpdateSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFileUpdateSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "#update_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileFull> UpdateFileRemoveSharedLink(string fileId, UpdateFileRemoveSharedLinkQueryParamsArg queryParams, UpdateFileRemoveSharedLinkRequestBodyArg? requestBody = default, UpdateFileRemoveSharedLinkHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFileRemoveSharedLinkRequestBodyArg();
            headers = headers ?? new UpdateFileRemoveSharedLinkHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "#remove_shared_link"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileFull>(response.Text);
        }

    }
}