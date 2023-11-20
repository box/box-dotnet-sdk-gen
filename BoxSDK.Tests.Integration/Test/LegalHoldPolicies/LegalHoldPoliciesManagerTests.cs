using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class LegalHoldPoliciesManagerTests {
        public BoxClient client { get; }

        public LegalHoldPoliciesManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateUpdateGetDeleteLegalHoldPolicy() {
            string legalHoldPolicyName = Utils.GetUUID();
            const string legalHoldDescription = "test description";
            LegalHoldPolicy legalHoldPolicy = await client.LegalHoldPolicies.CreateLegalHoldPolicyAsync(requestBody: new CreateLegalHoldPolicyRequestBodyArg(policyName: legalHoldPolicyName) { Description = legalHoldDescription, IsOngoing = true }).ConfigureAwait(false);
            Assert.IsTrue(legalHoldPolicy.PolicyName == legalHoldPolicyName);
            Assert.IsTrue(legalHoldPolicy.Description == legalHoldDescription);
            string legalHoldPolicyId = legalHoldPolicy.Id;
            LegalHoldPolicy legalHoldPolicyById = await client.LegalHoldPolicies.GetLegalHoldPolicyByIdAsync(legalHoldPolicyId: legalHoldPolicyId).ConfigureAwait(false);
            Assert.IsTrue(legalHoldPolicyById.Id == legalHoldPolicyId);
            LegalHoldPolicies legalHoldPolicies = await client.LegalHoldPolicies.GetLegalHoldPoliciesAsync().ConfigureAwait(false);
            Assert.IsTrue(legalHoldPolicies.Entries!.Count > 0);
            string updatedLegalHoldPolicyName = Utils.GetUUID();
            LegalHoldPolicy updatedLegalHoldPolicy = await client.LegalHoldPolicies.UpdateLegalHoldPolicyByIdAsync(legalHoldPolicyId: legalHoldPolicyId, requestBody: new UpdateLegalHoldPolicyByIdRequestBodyArg() { PolicyName = updatedLegalHoldPolicyName }).ConfigureAwait(false);
            Assert.IsTrue(updatedLegalHoldPolicy.PolicyName == updatedLegalHoldPolicyName);
            await client.LegalHoldPolicies.DeleteLegalHoldPolicyByIdAsync(legalHoldPolicyId: legalHoldPolicyId).ConfigureAwait(false);
        }

    }
}