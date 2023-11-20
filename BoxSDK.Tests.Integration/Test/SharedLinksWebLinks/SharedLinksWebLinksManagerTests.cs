using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class SharedLinksWebLinksManagerTests {
        public BoxClient client { get; }

        public SharedLinksWebLinksManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestSharedLinksWebLinks() {
            FolderFull parent = await client.Folders.GetFolderByIdAsync(folderId: "0").ConfigureAwait(false);
            WebLink webLink = await client.WebLinks.CreateWebLinkAsync(requestBody: new CreateWebLinkRequestBodyArg(url: "https://www.box.com", parent: new CreateWebLinkRequestBodyArgParentField(id: parent.Id)) { Name = Utils.GetUUID(), Description = "Weblink description" }).ConfigureAwait(false);
            string webLinkId = webLink.Id;
            await client.SharedLinksWebLinks.UpdateWebLinkAddSharedLinkAsync(webLinkId: webLinkId, requestBody: new UpdateWebLinkAddSharedLinkRequestBodyArg() { SharedLink = new UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkField() { Access = UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkFieldAccessField.Open, Password = "Secret123@" } }, queryParams: new UpdateWebLinkAddSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            WebLink webLinkFromApi = await client.SharedLinksWebLinks.GetWebLinkGetSharedLinkAsync(webLinkId: webLinkId, queryParams: new GetWebLinkGetSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(webLinkFromApi.SharedLink!.Access) == "open");
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = await new CommonsManager().GetDefaultClientAsUserAsync(userId: userId).ConfigureAwait(false);
            WebLink webLinkFromSharedLinkPassword = await userClient.SharedLinksWebLinks.GetSharedItemWebLinksAsync(queryParams: new GetSharedItemWebLinksQueryParamsArg(), headers: new GetSharedItemWebLinksHeadersArg(boxapi: string.Concat("shared_link=", webLinkFromApi.SharedLink!.Url, "&shared_link_password=Secret123@"))).ConfigureAwait(false);
            Assert.IsTrue(webLinkId == webLinkFromSharedLinkPassword.Id);
            await Assert.That.IsExceptionAsync(async() => await userClient.SharedLinksWebLinks.GetSharedItemWebLinksAsync(queryParams: new GetSharedItemWebLinksQueryParamsArg(), headers: new GetSharedItemWebLinksHeadersArg(boxapi: string.Concat("shared_link=", webLinkFromApi.SharedLink!.Url, "&shared_link_password=incorrectPassword"))).ConfigureAwait(false));
            WebLink updatedWebLink = await client.SharedLinksWebLinks.UpdateWebLinkUpdateSharedLinkAsync(webLinkId: webLinkId, requestBody: new UpdateWebLinkUpdateSharedLinkRequestBodyArg() { SharedLink = new UpdateWebLinkUpdateSharedLinkRequestBodyArgSharedLinkField() { Access = UpdateWebLinkUpdateSharedLinkRequestBodyArgSharedLinkFieldAccessField.Collaborators } }, queryParams: new UpdateWebLinkUpdateSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(updatedWebLink.SharedLink!.Access) == "collaborators");
            await client.WebLinks.DeleteWebLinkByIdAsync(webLinkId: webLinkId).ConfigureAwait(false);
        }

    }
}