using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class RetentionPoliciesManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public RetentionPoliciesManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateUpdateGetDeleteRetentionPolicy() {
            string retentionPolicyName = Utils.GetUUID();
            const string retentionDescription = "test description";
            RetentionPolicy retentionPolicy = await client.RetentionPolicies.CreateRetentionPolicy(new CreateRetentionPolicyRequestBodyArg(policyName: retentionPolicyName, policyType: CreateRetentionPolicyRequestBodyArgPolicyTypeField.Finite, dispositionAction: CreateRetentionPolicyRequestBodyArgDispositionActionField.RemoveRetention) { AreOwnersNotified = true, CanOwnerExtendRetention = true, Description = retentionDescription, RetentionLength = "1", RetentionType = CreateRetentionPolicyRequestBodyArgRetentionTypeField.Modifiable });
            Assert.IsTrue(retentionPolicy.PolicyName == retentionPolicyName);
            Assert.IsTrue(retentionPolicy.Description == retentionDescription);
            RetentionPolicy retentionPolicyById = await client.RetentionPolicies.GetRetentionPolicyById(retentionPolicy.Id);
            Assert.IsTrue(retentionPolicyById.Id == retentionPolicy.Id);
            RetentionPolicies retentionPolicies = await client.RetentionPolicies.GetRetentionPolicies();
            Assert.IsTrue(retentionPolicies.Entries.Count > 0);
            string updatedRetentionPolicyName = Utils.GetUUID();
            RetentionPolicy updatedRetentionPolicy = await client.RetentionPolicies.UpdateRetentionPolicyById(retentionPolicy.Id, new UpdateRetentionPolicyByIdRequestBodyArg() { PolicyName = updatedRetentionPolicyName });
            Assert.IsTrue(updatedRetentionPolicy.PolicyName == updatedRetentionPolicyName);
            await client.RetentionPolicies.DeleteRetentionPolicyById(retentionPolicy.Id);
        }

    }
}