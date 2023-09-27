using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class UsersManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public UsersManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetUsers() {
            Users users = await client.Users.GetUsersAsync().ConfigureAwait(false);
            Assert.IsTrue(users.TotalCount >= 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetUserMe() {
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(currentUser.Type) == "user");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateUpdateGetDeleteUser() {
            string userName = Utils.GetUUID();
            string userLogin = string.Concat(Utils.GetUUID(), "@gmail.com");
            User user = await client.Users.CreateUserAsync(new CreateUserRequestBodyArg(name: userName) { Login = userLogin, IsPlatformAccessOnly = true }).ConfigureAwait(false);
            Assert.IsTrue(user.Name == userName);
            UserFull userById = await client.Users.GetUserByIdAsync(user.Id).ConfigureAwait(false);
            Assert.IsTrue(userById.Id == user.Id);
            string updatedUserName = Utils.GetUUID();
            UserFull updatedUser = await client.Users.UpdateUserByIdAsync(user.Id, new UpdateUserByIdRequestBodyArg() { Name = updatedUserName }).ConfigureAwait(false);
            Assert.IsTrue(updatedUser.Name == updatedUserName);
            await client.Users.DeleteUserByIdAsync(user.Id).ConfigureAwait(false);
        }

    }
}