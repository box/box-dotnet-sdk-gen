using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class TrashedWebLinksManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public TrashedWebLinksManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestTrashedWebLinks() {
            const string url = "https://www.box.com";
            FolderFull parent = await client.Folders.GetFolderByIdAsync("0").ConfigureAwait(false);
            string name = Utils.GetUUID();
            const string description = "Weblink description";
            WebLink weblink = await client.WebLinks.CreateWebLinkAsync(new CreateWebLinkRequestBodyArg(url: url, parent: new CreateWebLinkRequestBodyArgParentField(id: parent.Id)) { Name = name, Description = description }).ConfigureAwait(false);
            await client.WebLinks.DeleteWebLinkByIdAsync(weblink.Id).ConfigureAwait(false);
            TrashWebLink fromTrash = await client.TrashedWebLinks.GetWebLinkTrashAsync(weblink.Id).ConfigureAwait(false);
            Assert.IsTrue(fromTrash.Id == weblink.Id);
            Assert.IsTrue(fromTrash.Name == weblink.Name);
            WebLink fromApiAfterTrashed = await client.WebLinks.GetWebLinkByIdAsync(weblink.Id).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(fromApiAfterTrashed.ItemStatus) == "trashed");
            TrashWebLinkRestored restoredWeblink = await client.TrashedWebLinks.RestoreWeblinkFromTrashAsync(weblink.Id).ConfigureAwait(false);
            WebLink fromApi = await client.WebLinks.GetWebLinkByIdAsync(weblink.Id).ConfigureAwait(false);
            Assert.IsTrue(restoredWeblink.Id == fromApi.Id);
            Assert.IsTrue(restoredWeblink.Name == fromApi.Name);
            await client.WebLinks.DeleteWebLinkByIdAsync(weblink.Id).ConfigureAwait(false);
            await client.TrashedWebLinks.DeleteWebLinkTrashAsync(weblink.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.TrashedWebLinks.GetWebLinkTrashAsync(weblink.Id).ConfigureAwait(false));
        }

    }
}