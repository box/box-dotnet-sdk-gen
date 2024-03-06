using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class DevicePinnersManagerTests {
        public BoxClient client { get; }

        public DevicePinnersManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestDevicePinners() {
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            DevicePinners devicePinners = await client.DevicePinners.GetEnterpriseDevicePinnersAsync(enterpriseId: enterpriseId).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(devicePinners.Entries).Count >= 0);
            DevicePinners devicePinnersInDescDirection = await client.DevicePinners.GetEnterpriseDevicePinnersAsync(enterpriseId: enterpriseId, queryParams: new GetEnterpriseDevicePinnersQueryParams() { Direction = GetEnterpriseDevicePinnersQueryParamsDirectionField.Desc }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(devicePinnersInDescDirection.Entries).Count >= 0);
            const string devicePinnerId = "123456";
            await Assert.That.IsExceptionAsync(async() => await client.DevicePinners.GetDevicePinnerByIdAsync(devicePinnerId: devicePinnerId).ConfigureAwait(false));
            await Assert.That.IsExceptionAsync(async() => await client.DevicePinners.DeleteDevicePinnerByIdAsync(devicePinnerId: devicePinnerId).ConfigureAwait(false));
        }

    }
}