using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
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
            WebLink webLink = await client.WebLinks.CreateWebLinkAsync(requestBody: new CreateWebLinkRequestBody(url: "https://www.box.com", parent: new CreateWebLinkRequestBodyParentField(id: parent.Id)) { Name = Utils.GetUUID(), Description = "Weblink description" }).ConfigureAwait(false);
            string webLinkId = webLink.Id;
            await client.SharedLinksWebLinks.AddShareLinkToWebLinkAsync(webLinkId: webLinkId, requestBody: new AddShareLinkToWebLinkRequestBody() { SharedLink = new AddShareLinkToWebLinkRequestBodySharedLinkField() { Access = AddShareLinkToWebLinkRequestBodySharedLinkAccessField.Open, Password = "Secret123@" } }, queryParams: new AddShareLinkToWebLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            WebLink webLinkFromApi = await client.SharedLinksWebLinks.GetSharedLinkForWebLinkAsync(webLinkId: webLinkId, queryParams: new GetSharedLinkForWebLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(webLinkFromApi.SharedLink).Access) == "open");
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = await new CommonsManager().GetDefaultClientAsUserAsync(userId: userId).ConfigureAwait(false);
            WebLink webLinkFromSharedLinkPassword = await userClient.SharedLinksWebLinks.FindWebLinkForSharedLinkAsync(queryParams: new FindWebLinkForSharedLinkQueryParams(), headers: new FindWebLinkForSharedLinkHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(webLinkFromApi.SharedLink).Url, "&shared_link_password=Secret123@"))).ConfigureAwait(false);
            Assert.IsTrue(webLinkId == webLinkFromSharedLinkPassword.Id);
            await Assert.That.IsExceptionAsync(async() => await userClient.SharedLinksWebLinks.FindWebLinkForSharedLinkAsync(queryParams: new FindWebLinkForSharedLinkQueryParams(), headers: new FindWebLinkForSharedLinkHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(webLinkFromApi.SharedLink).Url, "&shared_link_password=incorrectPassword"))).ConfigureAwait(false));
            WebLink updatedWebLink = await client.SharedLinksWebLinks.UpdateSharedLinkOnWebLinkAsync(webLinkId: webLinkId, requestBody: new UpdateSharedLinkOnWebLinkRequestBody() { SharedLink = new UpdateSharedLinkOnWebLinkRequestBodySharedLinkField() { Access = UpdateSharedLinkOnWebLinkRequestBodySharedLinkAccessField.Collaborators } }, queryParams: new UpdateSharedLinkOnWebLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(updatedWebLink.SharedLink).Access) == "collaborators");
            await client.WebLinks.DeleteWebLinkByIdAsync(webLinkId: webLinkId).ConfigureAwait(false);
        }

    }
}