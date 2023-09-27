using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Managers;
using Box.Schemas;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class AuthManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestCcgAuth() {
            string userId = Utils.GetEnvVar("USER_ID");
            string enterpriseId = Utils.GetEnvVar("ENTERPRISE_ID");
            CcgConfig ccgConfig = new CcgConfig(clientId: Utils.GetEnvVar("CLIENT_ID"), clientSecret: Utils.GetEnvVar("CLIENT_SECRET"), enterpriseId: enterpriseId, userId: userId);
            BoxCcgAuth auth = new BoxCcgAuth(config: ccgConfig);
            BoxClient client = new BoxClient(auth: auth);
            await auth.AsUserAsync(userId).ConfigureAwait(false);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(currentUser.Id == userId);
            await auth.AsEnterpriseAsync(enterpriseId).ConfigureAwait(false);
            UserFull newUser = await client.Users.GetUserMeAsync(new GetUserMeQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"enterprise"}) }).ConfigureAwait(false);
            Assert.IsTrue(newUser.Enterprise != null && newUser.Enterprise.Id == enterpriseId);
            Assert.IsTrue(newUser.Id != userId);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestJwtAuth() {
            string userId = Utils.GetEnvVar("USER_ID");
            string enterpriseId = Utils.GetEnvVar("ENTERPRISE_ID");
            JwtConfig jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            BoxJwtAuth auth = new BoxJwtAuth(config: jwtConfig);
            BoxClient client = new BoxClient(auth: auth);
            await auth.AsUserAsync(userId).ConfigureAwait(false);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(currentUser.Id == userId);
            await auth.AsEnterpriseAsync(enterpriseId).ConfigureAwait(false);
            UserFull newUser = await client.Users.GetUserMeAsync(new GetUserMeQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"enterprise"}) }).ConfigureAwait(false);
            Assert.IsTrue(newUser.Enterprise != null && newUser.Enterprise.Id == enterpriseId);
            Assert.IsTrue(newUser.Id != userId);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestDeveloperTokenAuth() {
            string userId = Utils.GetEnvVar("USER_ID");
            JwtConfig jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            BoxJwtAuth auth = new BoxJwtAuth(config: jwtConfig);
            await auth.AsUserAsync(userId).ConfigureAwait(false);
            AccessToken token = await auth.RetrieveTokenAsync().ConfigureAwait(false);
            BoxDeveloperTokenAuth devAuth = new BoxDeveloperTokenAuth(token: token.AccessTokenField);
            BoxClient client = new BoxClient(auth: devAuth);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(currentUser.Id == userId);
        }

        [TestMethod]
        public void TestOauthAuth() {
            OAuthConfig config = new OAuthConfig(clientId: "OAUTH_CLIENT_ID", clientSecret: "OAUTH_CLIENT_SECRET");
            BoxOAuth auth = new BoxOAuth(config: config);
            string authUrl = auth.GetAuthorizeUrl();
            const string expectedAuthUrl = "https://account.box.com/api/oauth2/authorize?client_id=OAUTH_CLIENT_ID&response_type=code";
            Assert.IsTrue(authUrl == expectedAuthUrl);
        }

    }
}