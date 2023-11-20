using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class SignTemplatesManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetSignTemplates() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            SignTemplates signTemplates = await client.SignTemplates.GetSignTemplatesAsync(queryParams: new GetSignTemplatesQueryParamsArg() { Limit = 2 }).ConfigureAwait(false);
            Assert.IsTrue(signTemplates.Entries!.Count >= 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetSignTemplate() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            SignTemplates signTemplates = await client.SignTemplates.GetSignTemplatesAsync(queryParams: new GetSignTemplatesQueryParamsArg() { Limit = 2 }).ConfigureAwait(false);
            Assert.IsTrue(signTemplates.Entries!.Count >= 0);
            if (signTemplates.Entries!.Count > 0) {
                SignTemplate signTemplate = await client.SignTemplates.GetSignTemplateByIdAsync(templateId: signTemplates.Entries![0].Id!).ConfigureAwait(false);
                Assert.IsTrue(signTemplate.Id == signTemplates.Entries![0].Id);
                Assert.IsTrue(signTemplate.SourceFiles!.Count > 0);
                Assert.IsTrue(signTemplate.Name != "");
                Assert.IsTrue(signTemplate.ParentFolder!.Id != "");
            }
        }

    }
}