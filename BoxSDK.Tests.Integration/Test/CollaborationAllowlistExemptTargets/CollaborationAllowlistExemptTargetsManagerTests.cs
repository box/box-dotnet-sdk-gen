using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class CollaborationAllowlistExemptTargetsManagerTests {
        public BoxClient client { get; }

        public CollaborationAllowlistExemptTargetsManagerTests() {
            client = new BoxClient(auth: new BoxJwtAuth(config: JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")))));
        }
        [TestMethod]
        public async System.Threading.Tasks.Task CollaborationAllowlistExemptTargets() {
            CollaborationAllowlistExemptTargets exemptTargets = await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetsAsync().ConfigureAwait(false);
            Assert.IsTrue(exemptTargets.Entries.Count >= 0);
            User user = await client.Users.CreateUserAsync(new CreateUserRequestBodyArg(name: Utils.GetUUID()) { Login = string.Concat(Utils.GetUUID(), "@boxdemo.com"), IsPlatformAccessOnly = true }).ConfigureAwait(false);
            CollaborationAllowlistExemptTarget newExemptTarget = await client.CollaborationAllowlistExemptTargets.CreateCollaborationWhitelistExemptTargetAsync(new CreateCollaborationWhitelistExemptTargetRequestBodyArg(user: new CreateCollaborationWhitelistExemptTargetRequestBodyArgUserField(id: user.Id))).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(newExemptTarget.Type) == "collaboration_whitelist_exempt_target");
            Assert.IsTrue(newExemptTarget.User.Id == user.Id);
            CollaborationAllowlistExemptTarget exemptTarget = await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetByIdAsync(newExemptTarget.Id).ConfigureAwait(false);
            Assert.IsTrue(exemptTarget.Id == newExemptTarget.Id);
            Assert.IsTrue(exemptTarget.User.Id == user.Id);
            await client.CollaborationAllowlistExemptTargets.DeleteCollaborationWhitelistExemptTargetByIdAsync(exemptTarget.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetByIdAsync(exemptTarget.Id).ConfigureAwait(false));
            await client.Users.DeleteUserByIdAsync(user.Id).ConfigureAwait(false);
        }

    }
}