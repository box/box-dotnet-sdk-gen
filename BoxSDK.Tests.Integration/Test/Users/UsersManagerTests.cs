using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using StringExtensions;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class UsersManagerTests {
        public BoxClient client { get; }

        public UsersManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetUsers() {
            Users users = await client.Users.GetUsersAsync().ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(users.TotalCount) >= 0);
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
            UserFull user = await client.Users.CreateUserAsync(requestBody: new CreateUserRequestBody(name: userName) { Login = userLogin, IsPlatformAccessOnly = true }).ConfigureAwait(false);
            Assert.IsTrue(user.Name == userName);
            UserFull userById = await client.Users.GetUserByIdAsync(userId: user.Id).ConfigureAwait(false);
            Assert.IsTrue(userById.Id == user.Id);
            string updatedUserName = Utils.GetUUID();
            UserFull updatedUser = await client.Users.UpdateUserByIdAsync(userId: user.Id, requestBody: new UpdateUserByIdRequestBody() { Name = updatedUserName }).ConfigureAwait(false);
            Assert.IsTrue(updatedUser.Name == updatedUserName);
            await client.Users.DeleteUserByIdAsync(userId: user.Id).ConfigureAwait(false);
        }

    }
}