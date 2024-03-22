using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using StringExtensions;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class StoragePoliciesManagerTests {
        public string userId { get; }

        public StoragePoliciesManagerTests() {
            userId = Utils.GetEnvVar(name: "USER_ID");
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetStoragePolicies() {
            BoxClient client = new CommonsManager().GetDefaultClientAsUser(userId: userId);
            StoragePolicies storagePolicies = await client.StoragePolicies.GetStoragePoliciesAsync();
            StoragePolicy storagePolicy = NullableUtils.Unwrap(storagePolicies.Entries)[0];
            Assert.IsTrue(StringUtils.ToStringRepresentation(storagePolicy.Type) == "storage_policy");
            StoragePolicy getStoragePolicy = await client.StoragePolicies.GetStoragePolicyByIdAsync(storagePolicyId: storagePolicy.Id);
            Assert.IsTrue(getStoragePolicy.Id == storagePolicy.Id);
        }

    }
}