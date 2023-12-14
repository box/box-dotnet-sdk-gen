using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class TrashedWebLinksManagerTests {
        public BoxClient client { get; }

        public TrashedWebLinksManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestTrashedWebLinks() {
            const string url = "https://www.box.com";
            FolderFull parent = await client.Folders.GetFolderByIdAsync(folderId: "0").ConfigureAwait(false);
            string name = Utils.GetUUID();
            const string description = "Weblink description";
            WebLink weblink = await client.WebLinks.CreateWebLinkAsync(requestBody: new CreateWebLinkRequestBody(url: url, parent: new CreateWebLinkRequestBodyParentField(id: parent.Id)) { Name = name, Description = description }).ConfigureAwait(false);
            await client.WebLinks.DeleteWebLinkByIdAsync(webLinkId: weblink.Id).ConfigureAwait(false);
            TrashWebLink fromTrash = await client.TrashedWebLinks.GetWebLinkTrashAsync(webLinkId: weblink.Id).ConfigureAwait(false);
            Assert.IsTrue(fromTrash.Id == weblink.Id);
            Assert.IsTrue(fromTrash.Name == weblink.Name);
            WebLink fromApiAfterTrashed = await client.WebLinks.GetWebLinkByIdAsync(webLinkId: weblink.Id).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(fromApiAfterTrashed.ItemStatus) == "trashed");
            TrashWebLinkRestored restoredWeblink = await client.TrashedWebLinks.RestoreWeblinkFromTrashAsync(webLinkId: weblink.Id).ConfigureAwait(false);
            WebLink fromApi = await client.WebLinks.GetWebLinkByIdAsync(webLinkId: weblink.Id).ConfigureAwait(false);
            Assert.IsTrue(restoredWeblink.Id == fromApi.Id);
            Assert.IsTrue(restoredWeblink.Name == fromApi.Name);
            await client.WebLinks.DeleteWebLinkByIdAsync(webLinkId: weblink.Id).ConfigureAwait(false);
            await client.TrashedWebLinks.DeleteWebLinkTrashAsync(webLinkId: weblink.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.TrashedWebLinks.GetWebLinkTrashAsync(webLinkId: weblink.Id).ConfigureAwait(false));
        }

    }
}