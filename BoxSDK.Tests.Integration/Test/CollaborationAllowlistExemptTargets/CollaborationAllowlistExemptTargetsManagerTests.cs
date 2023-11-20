using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class CollaborationAllowlistExemptTargetsManagerTests {
        public BoxClient client { get; }

        public CollaborationAllowlistExemptTargetsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task CollaborationAllowlistExemptTargets() {
            CollaborationAllowlistExemptTargets exemptTargets = await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetsAsync().ConfigureAwait(false);
            Assert.IsTrue(exemptTargets.Entries!.Count >= 0);
            UserFull user = await client.Users.CreateUserAsync(requestBody: new CreateUserRequestBodyArg(name: Utils.GetUUID()) { Login = string.Concat(Utils.GetUUID(), "@boxdemo.com"), IsPlatformAccessOnly = true }).ConfigureAwait(false);
            CollaborationAllowlistExemptTarget newExemptTarget = await client.CollaborationAllowlistExemptTargets.CreateCollaborationWhitelistExemptTargetAsync(requestBody: new CreateCollaborationWhitelistExemptTargetRequestBodyArg(user: new CreateCollaborationWhitelistExemptTargetRequestBodyArgUserField(id: user.Id))).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(newExemptTarget.Type) == "collaboration_whitelist_exempt_target");
            Assert.IsTrue(newExemptTarget.User!.Id == user.Id);
            CollaborationAllowlistExemptTarget exemptTarget = await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetByIdAsync(collaborationWhitelistExemptTargetId: newExemptTarget.Id!).ConfigureAwait(false);
            Assert.IsTrue(exemptTarget.Id == newExemptTarget.Id);
            Assert.IsTrue(exemptTarget.User!.Id == user.Id);
            await client.CollaborationAllowlistExemptTargets.DeleteCollaborationWhitelistExemptTargetByIdAsync(collaborationWhitelistExemptTargetId: exemptTarget.Id!).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetByIdAsync(collaborationWhitelistExemptTargetId: exemptTarget.Id!).ConfigureAwait(false));
            await client.Users.DeleteUserByIdAsync(userId: user.Id).ConfigureAwait(false);
        }

    }
}