using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using NullableExtensions;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class TermsOfServicesManagerTests {
        public BoxClient client { get; }

        public TermsOfServicesManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetTermsOfServices() {
            TermsOfService tos = await new CommonsManager().GetOrCreateTermsOfServicesAsync();
            TermsOfService updatedTos1 = await client.TermsOfServices.UpdateTermsOfServiceByIdAsync(termsOfServiceId: tos.Id, requestBody: new UpdateTermsOfServiceByIdRequestBody(status: UpdateTermsOfServiceByIdRequestBodyStatusField.Enabled, text: "Enabled TOS"));
            Assert.IsTrue(StringUtils.ToStringRepresentation(updatedTos1.Status?.Value) == "enabled");
            Assert.IsTrue(updatedTos1.Text == "Enabled TOS");
            TermsOfService updatedTos2 = await client.TermsOfServices.UpdateTermsOfServiceByIdAsync(termsOfServiceId: tos.Id, requestBody: new UpdateTermsOfServiceByIdRequestBody(status: UpdateTermsOfServiceByIdRequestBodyStatusField.Disabled, text: "Disabled TOS"));
            Assert.IsTrue(StringUtils.ToStringRepresentation(updatedTos2.Status?.Value) == "disabled");
            Assert.IsTrue(updatedTos2.Text == "Disabled TOS");
            TermsOfServices listTos = await client.TermsOfServices.GetTermsOfServiceAsync();
            Assert.IsTrue(NullableUtils.Unwrap(listTos.TotalCount) > 0);
        }

    }
}