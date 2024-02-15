using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using NullableExtensions;
using Unions;
using Box.Sdk.Gen.Managers;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class AuthManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestJwtAuth() {
            string userId = Utils.GetEnvVar(name: "USER_ID");
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            JwtConfig jwtConfig = JwtConfig.FromConfigJsonString(configJsonString: Utils.DecodeBase64(value: Utils.GetEnvVar(name: "JWT_CONFIG_BASE_64")));
            BoxJwtAuth auth = new BoxJwtAuth(config: jwtConfig);
            BoxJwtAuth userAuth = auth.AsUser(userId: userId);
            BoxClient userClient = new BoxClient(auth: userAuth);
            UserFull currentUser = await userClient.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(currentUser.Id == userId);
            BoxJwtAuth enterpriseAuth = auth.AsEnterprise(userId: enterpriseId);
            BoxClient enterpriseClient = new BoxClient(auth: enterpriseAuth);
            UserFull newUser = await enterpriseClient.Users.GetUserMeAsync(queryParams: new GetUserMeQueryParams() { Fields = Array.AsReadOnly(new [] {"enterprise"}) }).ConfigureAwait(false);
            Assert.IsTrue(newUser.Enterprise != null);
            Assert.IsTrue(NullableUtils.Unwrap(newUser.Enterprise).Id == enterpriseId);
            Assert.IsTrue(newUser.Id != userId);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestJwtAuthDownscope() {
            JwtConfig jwtConfig = JwtConfig.FromConfigJsonString(configJsonString: Utils.DecodeBase64(value: Utils.GetEnvVar(name: "JWT_CONFIG_BASE_64")));
            BoxJwtAuth auth = new BoxJwtAuth(config: jwtConfig);
            BoxClient parentClient = new BoxClient(auth: auth);
            Files uploadedFiles = await parentClient.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 1024 * 1024))).ConfigureAwait(false);
            FileFull file = NullableUtils.Unwrap(uploadedFiles.Entries)[0];
            string resourcePath = string.Concat("https://api.box.com/2.0/files/", file.Id);
            AccessToken downscopedToken = await auth.DownscopeTokenAsync(scopes: Array.AsReadOnly(new [] {"item_rename","item_preview"}), resource: resourcePath).ConfigureAwait(false);
            Assert.IsTrue(downscopedToken.AccessTokenField != null);
            BoxClient downscopedClient = new BoxClient(auth: new BoxDeveloperTokenAuth(token: downscopedToken.AccessTokenField));
            await downscopedClient.Files.UpdateFileByIdAsync(fileId: file.Id, requestBody: new UpdateFileByIdRequestBody() { Name = Utils.GetUUID() }).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await downscopedClient.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false));
            await parentClient.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestJwtAuthRevoke() {
            JwtConfig jwtConfig = JwtConfig.FromConfigJsonString(configJsonString: Utils.DecodeBase64(value: Utils.GetEnvVar(name: "JWT_CONFIG_BASE_64")));
            BoxJwtAuth auth = new BoxJwtAuth(config: jwtConfig);
            await auth.RetrieveTokenAsync().ConfigureAwait(false);
            AccessToken? tokenFromStorageBeforeRevoke = await auth.TokenStorage.GetAsync().ConfigureAwait(false);
            await auth.RevokeTokenAsync().ConfigureAwait(false);
            AccessToken? tokenFromStorageAfterRevoke = await auth.TokenStorage.GetAsync().ConfigureAwait(false);
            Assert.IsTrue(tokenFromStorageBeforeRevoke != null);
            Assert.IsTrue(tokenFromStorageAfterRevoke == null);
        }

        [TestMethod]
        public void TestOauthAuthAuthorizeUrl() {
            OAuthConfig config = new OAuthConfig(clientId: "OAUTH_CLIENT_ID", clientSecret: "OAUTH_CLIENT_SECRET");
            BoxOAuth auth = new BoxOAuth(config: config);
            string authUrl = auth.GetAuthorizeUrl();
            Assert.IsTrue(authUrl == "https://account.box.com/api/oauth2/authorize?client_id=OAUTH_CLIENT_ID&response_type=code" || authUrl == "https://account.box.com/api/oauth2/authorize?response_type=code&client_id=OAUTH_CLIENT_ID");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCcgAuth() {
            string userId = Utils.GetEnvVar(name: "USER_ID");
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            CcgConfig ccgConfig = new CcgConfig(clientId: Utils.GetEnvVar(name: "CLIENT_ID"), clientSecret: Utils.GetEnvVar(name: "CLIENT_SECRET")) { EnterpriseId = enterpriseId, UserId = userId };
            BoxCcgAuth auth = new BoxCcgAuth(config: ccgConfig);
            BoxCcgAuth userAuth = auth.AsUser(userId: userId);
            BoxClient userClient = new BoxClient(auth: userAuth);
            UserFull currentUser = await userClient.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(currentUser.Id == userId);
            BoxCcgAuth enterpriseAuth = auth.AsEnterprise(enterpriseId: enterpriseId);
            BoxClient enterpriseClient = new BoxClient(auth: enterpriseAuth);
            UserFull newUser = await enterpriseClient.Users.GetUserMeAsync(queryParams: new GetUserMeQueryParams() { Fields = Array.AsReadOnly(new [] {"enterprise"}) }).ConfigureAwait(false);
            Assert.IsTrue(newUser.Enterprise != null);
            Assert.IsTrue(NullableUtils.Unwrap(newUser.Enterprise).Id == enterpriseId);
            Assert.IsTrue(newUser.Id != userId);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCcgAuthDownscope() {
            CcgConfig ccgConfig = new CcgConfig(clientId: Utils.GetEnvVar(name: "CLIENT_ID"), clientSecret: Utils.GetEnvVar(name: "CLIENT_SECRET")) { UserId = Utils.GetEnvVar(name: "USER_ID") };
            BoxCcgAuth auth = new BoxCcgAuth(config: ccgConfig);
            BoxClient parentClient = new BoxClient(auth: auth);
            FolderFull folder = await parentClient.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyParentField(id: "0"))).ConfigureAwait(false);
            string resourcePath = string.Concat("https://api.box.com/2.0/folders/", folder.Id);
            AccessToken downscopedToken = await auth.DownscopeTokenAsync(scopes: Array.AsReadOnly(new [] {"item_rename","item_preview"}), resource: resourcePath).ConfigureAwait(false);
            Assert.IsTrue(downscopedToken.AccessTokenField != null);
            BoxClient downscopedClient = new BoxClient(auth: new BoxDeveloperTokenAuth(token: downscopedToken.AccessTokenField));
            await downscopedClient.Folders.UpdateFolderByIdAsync(folderId: folder.Id, requestBody: new UpdateFolderByIdRequestBody() { Name = Utils.GetUUID() }).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await downscopedClient.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false));
            await parentClient.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCcgAuthRevoke() {
            CcgConfig ccgConfig = new CcgConfig(clientId: Utils.GetEnvVar(name: "CLIENT_ID"), clientSecret: Utils.GetEnvVar(name: "CLIENT_SECRET")) { UserId = Utils.GetEnvVar(name: "USER_ID") };
            BoxCcgAuth auth = new BoxCcgAuth(config: ccgConfig);
            await auth.RetrieveTokenAsync().ConfigureAwait(false);
            AccessToken? tokenFromStorageBeforeRevoke = await auth.TokenStorage.GetAsync().ConfigureAwait(false);
            await auth.RevokeTokenAsync().ConfigureAwait(false);
            AccessToken? tokenFromStorageAfterRevoke = await auth.TokenStorage.GetAsync().ConfigureAwait(false);
            Assert.IsTrue(tokenFromStorageBeforeRevoke != null);
            Assert.IsTrue(tokenFromStorageAfterRevoke == null);
        }

        public async System.Threading.Tasks.Task<AccessToken> GetAccessTokenAsync() {
            string userId = Utils.GetEnvVar(name: "USER_ID");
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            CcgConfig ccgConfig = new CcgConfig(clientId: Utils.GetEnvVar(name: "CLIENT_ID"), clientSecret: Utils.GetEnvVar(name: "CLIENT_SECRET")) { EnterpriseId = enterpriseId, UserId = userId };
            BoxCcgAuth auth = new BoxCcgAuth(config: ccgConfig);
            auth.AsUser(userId: userId);
            AccessToken token = await auth.RetrieveTokenAsync().ConfigureAwait(false);
            return token;
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestDeveloperTokenAuth() {
            string userId = Utils.GetEnvVar(name: "USER_ID");
            AccessToken token = await GetAccessTokenAsync().ConfigureAwait(false);
            BoxDeveloperTokenAuth devAuth = new BoxDeveloperTokenAuth(token: token.AccessTokenField);
            BoxClient client = new BoxClient(auth: devAuth);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(currentUser.Id == userId);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestOauthAuthRevoke() {
            OAuthConfig config = new OAuthConfig(clientId: Utils.GetEnvVar(name: "CLIENT_ID"), clientSecret: Utils.GetEnvVar(name: "CLIENT_SECRET"));
            BoxOAuth auth = new BoxOAuth(config: config);
            AccessToken token = await GetAccessTokenAsync().ConfigureAwait(false);
            await auth.TokenStorage.StoreAsync(token: token).ConfigureAwait(false);
            AccessToken? tokenBeforeRevoke = await auth.TokenStorage.GetAsync().ConfigureAwait(false);
            await auth.RevokeTokenAsync().ConfigureAwait(false);
            AccessToken? tokenAfterRevoke = await auth.TokenStorage.GetAsync().ConfigureAwait(false);
            Assert.IsTrue(tokenBeforeRevoke != null);
            Assert.IsTrue(tokenAfterRevoke == null);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestOauthAuthDownscope() {
            OAuthConfig config = new OAuthConfig(clientId: Utils.GetEnvVar(name: "CLIENT_ID"), clientSecret: Utils.GetEnvVar(name: "CLIENT_SECRET"));
            BoxOAuth auth = new BoxOAuth(config: config);
            AccessToken token = await GetAccessTokenAsync().ConfigureAwait(false);
            await auth.TokenStorage.StoreAsync(token: token).ConfigureAwait(false);
            BoxClient parentClient = new BoxClient(auth: auth);
            Files uploadedFiles = await parentClient.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 1024 * 1024))).ConfigureAwait(false);
            FileFull file = NullableUtils.Unwrap(uploadedFiles.Entries)[0];
            string resourcePath = string.Concat("https://api.box.com/2.0/files/", file.Id);
            AccessToken downscopedToken = await auth.DownscopeTokenAsync(scopes: Array.AsReadOnly(new [] {"item_rename","item_preview"}), resource: resourcePath).ConfigureAwait(false);
            Assert.IsTrue(downscopedToken.AccessTokenField != null);
            BoxClient downscopedClient = new BoxClient(auth: new BoxDeveloperTokenAuth(token: downscopedToken.AccessTokenField));
            await downscopedClient.Files.UpdateFileByIdAsync(fileId: file.Id, requestBody: new UpdateFileByIdRequestBody() { Name = Utils.GetUUID() }).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await downscopedClient.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false));
            await parentClient.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

    }
}