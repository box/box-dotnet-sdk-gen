using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NullableExtensions;
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
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyParentField(id: "0"))).ConfigureAwait(false);
            const string slackOrgId = "1";
            const string partnerItemId = "1";
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = new CommonsManager().GetDefaultClientAsUser(userId: userId);
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.CreateSlackIntegrationMappingAsync(requestBody: new IntegrationMappingSlackCreateRequest(partnerItem: new IntegrationMappingPartnerItemSlack(type: IntegrationMappingPartnerItemSlackTypeField.Channel, id: partnerItemId) { SlackOrgId = slackOrgId }, boxItem: new IntegrationMappingBoxItemSlack(id: folder.Id, type: IntegrationMappingBoxItemSlackTypeField.Folder))).ConfigureAwait(false));
            IntegrationMappings integrationMappings = await userClient.IntegrationMappings.GetSlackIntegrationMappingAsync().ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(integrationMappings.Entries).Count == 0);
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}