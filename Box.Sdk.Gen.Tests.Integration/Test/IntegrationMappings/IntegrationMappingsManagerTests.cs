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
        public async System.Threading.Tasks.Task TestSlackIntegrationMappings() {
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyParentField(id: "0")));
            const string slackOrgId = "1";
            const string partnerItemId = "1";
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = new CommonsManager().GetDefaultClientWithUserSubject(userId: userId);
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.CreateSlackIntegrationMappingAsync(requestBody: new IntegrationMappingSlackCreateRequest(partnerItem: new IntegrationMappingPartnerItemSlack(id: partnerItemId) { SlackOrgId = slackOrgId }, boxItem: new IntegrationMappingBoxItemSlack(id: folder.Id))));
            IntegrationMappings integrationMappings = await userClient.IntegrationMappings.GetSlackIntegrationMappingAsync();
            Assert.IsTrue(NullableUtils.Unwrap(integrationMappings.Entries).Count == 0);
            const string integrationMappingId = "123456";
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.UpdateSlackIntegrationMappingByIdAsync(integrationMappingId: integrationMappingId, requestBody: new UpdateSlackIntegrationMappingByIdRequestBody() { BoxItem = new IntegrationMappingBoxItemSlack(id: "1234567") }));
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.DeleteSlackIntegrationMappingByIdAsync(integrationMappingId: integrationMappingId));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestTeamsIntegrationMappings() {
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyParentField(id: "0")));
            const string tenantId = "1";
            const string teamId = "2";
            const string partnerItemId = "3";
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = new CommonsManager().GetDefaultClientWithUserSubject(userId: userId);
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.CreateTeamsIntegrationMappingAsync(requestBody: new IntegrationMappingTeamsCreateRequest(partnerItem: new IntegrationMappingPartnerItemTeamsCreateRequest(type: IntegrationMappingPartnerItemTeamsCreateRequestTypeField.Channel, id: partnerItemId, tenantId: tenantId, teamId: teamId), boxItem: new FolderReference(id: folder.Id))));
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.GetTeamsIntegrationMappingAsync());
            const string integrationMappingId = "123456";
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.UpdateTeamsIntegrationMappingByIdAsync(integrationMappingId: integrationMappingId, requestBody: new UpdateTeamsIntegrationMappingByIdRequestBody() { BoxItem = new FolderReference(id: "1234567") }));
            await Assert.That.IsExceptionAsync(async() => await userClient.IntegrationMappings.DeleteTeamsIntegrationMappingByIdAsync(integrationMappingId: integrationMappingId));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id);
        }

    }
}