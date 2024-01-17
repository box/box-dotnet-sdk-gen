using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using NullableExtensions;
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
            BoxClient client = new BoxClient(auth: auth);
            await auth.AsUserAsync(userId: userId).ConfigureAwait(false);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(currentUser.Id == userId);
            await auth.AsEnterpriseAsync(userId: enterpriseId).ConfigureAwait(false);
            UserFull newUser = await client.Users.GetUserMeAsync(queryParams: new GetUserMeQueryParams() { Fields = Array.AsReadOnly(new [] {"enterprise"}) }).ConfigureAwait(false);
            Assert.IsTrue(newUser.Enterprise != null);
            Assert.IsTrue(NullableUtils.Unwrap(newUser.Enterprise).Id == enterpriseId);
            Assert.IsTrue(newUser.Id != userId);
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
            CcgConfig ccgConfig = new CcgConfig(clientId: Utils.GetEnvVar(name: "CLIENT_ID"), clientSecret: Utils.GetEnvVar(name: "CLIENT_SECRET"), enterpriseId: enterpriseId, userId: userId);
            BoxCcgAuth auth = new BoxCcgAuth(config: ccgConfig);
            BoxClient client = new BoxClient(auth: auth);
            await auth.AsUserAsync(userId: userId).ConfigureAwait(false);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(currentUser.Id == userId);
            await auth.AsEnterpriseAsync(enterpriseId: enterpriseId).ConfigureAwait(false);
            UserFull newUser = await client.Users.GetUserMeAsync(queryParams: new GetUserMeQueryParams() { Fields = Array.AsReadOnly(new [] {"enterprise"}) }).ConfigureAwait(false);
            Assert.IsTrue(newUser.Enterprise != null);
            Assert.IsTrue(NullableUtils.Unwrap(newUser.Enterprise).Id == enterpriseId);
            Assert.IsTrue(newUser.Id != userId);
        }

        public async System.Threading.Tasks.Task<AccessToken> GetAccessTokenAsync() {
            string userId = Utils.GetEnvVar(name: "USER_ID");
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            CcgConfig ccgConfig = new CcgConfig(clientId: Utils.GetEnvVar(name: "CLIENT_ID"), clientSecret: Utils.GetEnvVar(name: "CLIENT_SECRET"), enterpriseId: enterpriseId, userId: userId);
            BoxCcgAuth auth = new BoxCcgAuth(config: ccgConfig);
            await auth.AsUserAsync(userId: userId).ConfigureAwait(false);
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

    }
}