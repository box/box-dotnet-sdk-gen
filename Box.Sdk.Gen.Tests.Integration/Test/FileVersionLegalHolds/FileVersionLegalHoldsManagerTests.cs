using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class FileVersionLegalHoldsManagerTests {
        public BoxClient client { get; }

        public FileVersionLegalHoldsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task GetFileVersionLegalHolds() {
            const string policyId = "1234567890";
            FileVersionLegalHolds fileVersionLegalHolds = await client.FileVersionLegalHolds.GetFileVersionLegalHoldsAsync(queryParams: new GetFileVersionLegalHoldsQueryParams(policyId: policyId)).ConfigureAwait(false);
            int fileVersionLegalHoldsCount = NullableUtils.Unwrap(fileVersionLegalHolds.Entries).Count;
            Assert.IsTrue(fileVersionLegalHoldsCount >= 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetFileVersionLegalHoldById() {
            const string fileVersionLegalHoldId = "987654321";
            await Assert.That.IsExceptionAsync(async() => await client.FileVersionLegalHolds.GetFileVersionLegalHoldByIdAsync(fileVersionLegalHoldId: fileVersionLegalHoldId).ConfigureAwait(false));
        }

    }
}