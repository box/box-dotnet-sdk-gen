using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using NullableExtensions;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class SessionTerminationManagerTests {
        public BoxClient client { get; }

        public SessionTerminationManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestSessionTerminationUser() {
            BoxClient adminClient = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            UserFull user = await adminClient.Users.GetUserMeAsync().ConfigureAwait(false);
            SessionTerminationMessage result = await client.SessionTermination.CreateUserTerminateSessionAsync(requestBody: new CreateUserTerminateSessionRequestBody(userIds: Array.AsReadOnly(new [] {Utils.GetEnvVar(name: "USER_ID")}), userLogins: Array.AsReadOnly(new [] {NullableUtils.Unwrap(user.Login)}))).ConfigureAwait(false);
            Assert.IsTrue(result.Message == "Request is successful, please check the admin events for the status of the job");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestSessionTerminationGroup() {
            string groupName = Utils.GetUUID();
            GroupFull group = await client.Groups.CreateGroupAsync(requestBody: new CreateGroupRequestBody(name: groupName)).ConfigureAwait(false);
            SessionTerminationMessage result = await client.SessionTermination.CreateGroupTerminateSessionAsync(requestBody: new CreateGroupTerminateSessionRequestBody(groupIds: Array.AsReadOnly(new [] {group.Id}))).ConfigureAwait(false);
            Assert.IsTrue(result.Message == "Request is successful, please check the admin events for the status of the job");
            await client.Groups.DeleteGroupByIdAsync(groupId: group.Id).ConfigureAwait(false);
        }

    }
}