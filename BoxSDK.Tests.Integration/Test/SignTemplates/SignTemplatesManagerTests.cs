using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class SignTemplatesManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public SignTemplatesManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetSignTemplates() {
            await auth.AsUserAsync(Utils.GetEnvVar("USER_ID")).ConfigureAwait(false);
            SignTemplates signTemplates = await client.SignTemplates.GetSignTemplatesAsync(new GetSignTemplatesQueryParamsArg() { Limit = 2 }).ConfigureAwait(false);
            Assert.IsTrue(signTemplates.Entries!.Count >= 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetSignTemplate() {
            await auth.AsUserAsync(Utils.GetEnvVar("USER_ID")).ConfigureAwait(false);
            SignTemplates signTemplates = await client.SignTemplates.GetSignTemplatesAsync(new GetSignTemplatesQueryParamsArg() { Limit = 2 }).ConfigureAwait(false);
            Assert.IsTrue(signTemplates.Entries!.Count >= 0);
            if (signTemplates.Entries!.Count > 0) {
                SignTemplate signTemplate = await client.SignTemplates.GetSignTemplateByIdAsync(signTemplates.Entries![0].Id!).ConfigureAwait(false);
                Assert.IsTrue(signTemplate.Id == signTemplates.Entries![0].Id);
                Assert.IsTrue(signTemplate.SourceFiles!.Count > 0);
                Assert.IsTrue(signTemplate.Name != "");
                Assert.IsTrue(signTemplate.ParentFolder!.Id != "");
            }
        }

    }
}