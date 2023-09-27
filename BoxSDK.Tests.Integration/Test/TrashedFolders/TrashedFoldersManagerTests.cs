using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class TrashedFoldersManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public TrashedFoldersManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestTrashedFolders() {
            FolderFull folder = await client.Folders.CreateFolderAsync(new CreateFolderRequestBodyArg(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyArgParentField(id: "0"))).ConfigureAwait(false);
            await client.Folders.DeleteFolderByIdAsync(folder.Id).ConfigureAwait(false);
            TrashFolder fromTrash = await client.TrashedFolders.GetFolderTrashAsync(folder.Id).ConfigureAwait(false);
            Assert.IsTrue(fromTrash.Id == folder.Id);
            Assert.IsTrue(fromTrash.Name == folder.Name);
            await Assert.That.IsExceptionAsync(async() => await client.Folders.GetFolderByIdAsync(folder.Id).ConfigureAwait(false));
            TrashFolderRestored restoredFolder = await client.TrashedFolders.RestoreFolderFromTrashAsync(folder.Id).ConfigureAwait(false);
            FolderFull fromApi = await client.Folders.GetFolderByIdAsync(folder.Id).ConfigureAwait(false);
            Assert.IsTrue(restoredFolder.Id == fromApi.Id);
            Assert.IsTrue(restoredFolder.Name == fromApi.Name);
            await client.Folders.DeleteFolderByIdAsync(folder.Id).ConfigureAwait(false);
            await client.TrashedFolders.DeleteFolderTrashAsync(folder.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.TrashedFolders.GetFolderTrashAsync(folder.Id).ConfigureAwait(false));
        }

    }
}