using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class SignTemplatesManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetSignTemplates() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            SignTemplates signTemplates = await client.SignTemplates.GetSignTemplatesAsync(queryParams: new GetSignTemplatesQueryParams() { Limit = 2 }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(signTemplates.Entries).Count >= 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetSignTemplate() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            SignTemplates signTemplates = await client.SignTemplates.GetSignTemplatesAsync(queryParams: new GetSignTemplatesQueryParams() { Limit = 2 }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(signTemplates.Entries).Count >= 0);
            if (NullableUtils.Unwrap(signTemplates.Entries).Count > 0) {
                SignTemplate signTemplate = await client.SignTemplates.GetSignTemplateByIdAsync(templateId: NullableUtils.Unwrap(NullableUtils.Unwrap(signTemplates.Entries)[0].Id)).ConfigureAwait(false);
                Assert.IsTrue(signTemplate.Id == NullableUtils.Unwrap(signTemplates.Entries)[0].Id);
                Assert.IsTrue(NullableUtils.Unwrap(signTemplate.SourceFiles).Count > 0);
                Assert.IsTrue(signTemplate.Name != "");
                Assert.IsTrue(NullableUtils.Unwrap(signTemplate.ParentFolder).Id != "");
            }
        }

    }
}