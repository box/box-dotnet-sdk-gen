using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class IntegrationMappingsManagerTests {
        public BoxClient client { get; }

        public IntegrationMappingsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestIntegrationMappings() {
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyParentField(id: "0")));
            const string slackOrgId = "1";
            const string partnerItemId = "1";
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = new CommonsManager().GetDefaultClientWithUserSubject(userId: userId);
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.CreateSlackIntegrationMappingAsync(requestBody: new IntegrationMappingSlackCreateRequest(boxItem: new IntegrationMappingBoxItemSlack(id: folder.Id)) { PartnerItem = new IntegrationMappingPartnerItemSlack(id: partnerItemId) { SlackOrgId = slackOrgId } }));
            IntegrationMappings integrationMappings = await userClient.IntegrationMappings.GetSlackIntegrationMappingAsync();
            Assert.IsTrue(NullableUtils.Unwrap(integrationMappings.Entries).Count == 0);
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id);
        }

    }
}