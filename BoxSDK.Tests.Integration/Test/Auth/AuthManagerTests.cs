using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            await auth.AsUser(userId);
            UserFull currentUser = await client.Users.GetUserMe();
            Assert.IsTrue(currentUser.Id == userId);
            await auth.AsEnterprise(enterpriseId);
            UserFull newUser = await client.Users.GetUserMe(new GetUserMeQueryParamsArg() { Fields = "enterprise" });
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
            await auth.AsUser(userId);
            UserFull currentUser = await client.Users.GetUserMe();
            Assert.IsTrue(currentUser.Id == userId);
            await auth.AsEnterprise(enterpriseId);
            UserFull newUser = await client.Users.GetUserMe(new GetUserMeQueryParamsArg() { Fields = "enterprise" });
            Assert.IsTrue(newUser.Enterprise != null && newUser.Enterprise.Id == enterpriseId);
            Assert.IsTrue(newUser.Id != userId);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestDeveloperTokenAuth() {
            string userId = Utils.GetEnvVar("USER_ID");
            JwtConfig jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            BoxJwtAuth auth = new BoxJwtAuth(config: jwtConfig);
            await auth.AsUser(userId);
            AccessToken token = await auth.RetrieveToken();
            BoxDeveloperTokenAuth devAuth = new BoxDeveloperTokenAuth(token: token.AccessTokenField);
            BoxClient client = new BoxClient(auth: devAuth);
            UserFull currentUser = await client.Users.GetUserMe();
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