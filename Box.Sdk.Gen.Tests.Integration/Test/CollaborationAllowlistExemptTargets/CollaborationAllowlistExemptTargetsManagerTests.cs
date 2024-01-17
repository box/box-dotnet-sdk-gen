using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using StringExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class CollaborationAllowlistExemptTargetsManagerTests {
        public BoxClient client { get; }

        public CollaborationAllowlistExemptTargetsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task CollaborationAllowlistExemptTargets() {
            CollaborationAllowlistExemptTargets exemptTargets = await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetsAsync().ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(exemptTargets.Entries).Count >= 0);
            UserFull user = await client.Users.CreateUserAsync(requestBody: new CreateUserRequestBody(name: Utils.GetUUID()) { Login = string.Concat(Utils.GetUUID(), "@boxdemo.com"), IsPlatformAccessOnly = true }).ConfigureAwait(false);
            CollaborationAllowlistExemptTarget newExemptTarget = await client.CollaborationAllowlistExemptTargets.CreateCollaborationWhitelistExemptTargetAsync(requestBody: new CreateCollaborationWhitelistExemptTargetRequestBody(user: new CreateCollaborationWhitelistExemptTargetRequestBodyUserField(id: user.Id))).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(newExemptTarget.Type) == "collaboration_whitelist_exempt_target");
            Assert.IsTrue(NullableUtils.Unwrap(newExemptTarget.User).Id == user.Id);
            CollaborationAllowlistExemptTarget exemptTarget = await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetByIdAsync(collaborationWhitelistExemptTargetId: NullableUtils.Unwrap(newExemptTarget.Id)).ConfigureAwait(false);
            Assert.IsTrue(exemptTarget.Id == newExemptTarget.Id);
            Assert.IsTrue(NullableUtils.Unwrap(exemptTarget.User).Id == user.Id);
            await client.CollaborationAllowlistExemptTargets.DeleteCollaborationWhitelistExemptTargetByIdAsync(collaborationWhitelistExemptTargetId: NullableUtils.Unwrap(exemptTarget.Id)).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetByIdAsync(collaborationWhitelistExemptTargetId: NullableUtils.Unwrap(exemptTarget.Id)).ConfigureAwait(false));
            await client.Users.DeleteUserByIdAsync(userId: user.Id).ConfigureAwait(false);
        }

    }
}