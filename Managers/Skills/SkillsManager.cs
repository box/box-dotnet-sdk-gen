using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class SkillsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public SkillsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<SkillCardsMetadata> GetFileMetadataGlobalBoxSkillsCards(string fileId, GetFileMetadataGlobalBoxSkillsCardsHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/global/boxSkillsCards"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SkillCardsMetadata>(response.Text);
        }

        public async System.Threading.Tasks.Task<SkillCardsMetadata> CreateFileMetadataGlobalBoxSkillsCard(string fileId, CreateFileMetadataGlobalBoxSkillsCardRequestBodyArg requestBody, CreateFileMetadataGlobalBoxSkillsCardHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/global/boxSkillsCards"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SkillCardsMetadata>(response.Text);
        }

        public async System.Threading.Tasks.Task<SkillCardsMetadata> UpdateFileMetadataGlobalBoxSkillsCard(string fileId, UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArg requestBody, UpdateFileMetadataGlobalBoxSkillsCardHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/global/boxSkillsCards"), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json-patch+json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SkillCardsMetadata>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFileMetadataGlobalBoxSkillsCard(string fileId, DeleteFileMetadataGlobalBoxSkillsCardHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/metadata/global/boxSkillsCards"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task UpdateSkillInvocationById(string skillId, UpdateSkillInvocationByIdRequestBodyArg requestBody, UpdateSkillInvocationByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/skill_invocations/", skillId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}