using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class RetentionPoliciesManagerTests {
        public BoxClient client { get; }

        public RetentionPoliciesManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateUpdateGetDeleteRetentionPolicy() {
            string retentionPolicyName = Utils.GetUUID();
            const string retentionDescription = "test description";
            RetentionPolicy retentionPolicy = await client.RetentionPolicies.CreateRetentionPolicyAsync(new CreateRetentionPolicyRequestBodyArg(policyName: retentionPolicyName, policyType: CreateRetentionPolicyRequestBodyArgPolicyTypeField.Finite, dispositionAction: CreateRetentionPolicyRequestBodyArgDispositionActionField.RemoveRetention) { AreOwnersNotified = true, CanOwnerExtendRetention = true, Description = retentionDescription, RetentionLength = "1", RetentionType = CreateRetentionPolicyRequestBodyArgRetentionTypeField.Modifiable }).ConfigureAwait(false);
            Assert.IsTrue(retentionPolicy.PolicyName == retentionPolicyName);
            Assert.IsTrue(retentionPolicy.Description == retentionDescription);
            RetentionPolicy retentionPolicyById = await client.RetentionPolicies.GetRetentionPolicyByIdAsync(retentionPolicy.Id).ConfigureAwait(false);
            Assert.IsTrue(retentionPolicyById.Id == retentionPolicy.Id);
            RetentionPolicies retentionPolicies = await client.RetentionPolicies.GetRetentionPoliciesAsync().ConfigureAwait(false);
            Assert.IsTrue(retentionPolicies.Entries!.Count > 0);
            string updatedRetentionPolicyName = Utils.GetUUID();
            RetentionPolicy updatedRetentionPolicy = await client.RetentionPolicies.UpdateRetentionPolicyByIdAsync(retentionPolicy.Id, new UpdateRetentionPolicyByIdRequestBodyArg() { PolicyName = updatedRetentionPolicyName }).ConfigureAwait(false);
            Assert.IsTrue(updatedRetentionPolicy.PolicyName == updatedRetentionPolicyName);
            await client.RetentionPolicies.DeleteRetentionPolicyByIdAsync(retentionPolicy.Id).ConfigureAwait(false);
        }

    }
}