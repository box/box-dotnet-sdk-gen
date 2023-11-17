using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class ClientManagerTests {
        public BoxClient client { get; }

        public ClientManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestWithAsUserHeader() {
            string userName = Utils.GetUUID();
            UserFull createdUser = await client.Users.CreateUserAsync(new CreateUserRequestBodyArg(name: userName) { IsPlatformAccessOnly = true }).ConfigureAwait(false);
            BoxClient asUserClient = client.WithAsUserHeader(createdUser.Id);
            UserFull adminUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(adminUser.Name) != userName);
            UserFull appUser = await asUserClient.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(appUser.Name) == userName);
            await client.Users.DeleteUserByIdAsync(createdUser.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestWithSuppressedNotifications() {
            BoxClient newClient = client.WithSuppressedNotifications();
            UserFull user = await newClient.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(user.Id != "");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestWithExtraHeaders() {
            string userName = Utils.GetUUID();
            UserFull createdUser = await client.Users.CreateUserAsync(new CreateUserRequestBodyArg(name: userName) { IsPlatformAccessOnly = true }).ConfigureAwait(false);
            BoxClient asUserClient = client.WithExtraHeaders(new Dictionary<string, string>() { { "As-User", createdUser.Id } });
            UserFull adminUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(adminUser.Name) != userName);
            UserFull appUser = await asUserClient.Users.GetUserMeAsync().ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(appUser.Name) == userName);
            await client.Users.DeleteUserByIdAsync(createdUser.Id).ConfigureAwait(false);
        }

    }
}