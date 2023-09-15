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
            FolderFull folder = await client.Folders.CreateFolder(new CreateFolderRequestBodyArg(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyArgParentField(id: "0")));
            await client.Folders.DeleteFolderById(folder.Id);
            TrashFolder fromTrash = await client.TrashedFolders.GetFolderTrash(folder.Id);
            Assert.IsTrue(fromTrash.Id == folder.Id);
            Assert.IsTrue(fromTrash.Name == folder.Name);
            await Assert.ThrowsExceptionAsync<Exception>(async() => await client.Folders.GetFolderById(folder.Id));
            TrashFolderRestored restoredFolder = await client.TrashedFolders.RestoreFolderFromTrash(folder.Id);
            FolderFull fromApi = await client.Folders.GetFolderById(folder.Id);
            Assert.IsTrue(restoredFolder.Id == fromApi.Id);
            Assert.IsTrue(restoredFolder.Name == fromApi.Name);
            await client.Folders.DeleteFolderById(folder.Id);
            await client.TrashedFolders.DeleteFolderTrash(folder.Id);
            await Assert.ThrowsExceptionAsync<Exception>(async() => await client.TrashedFolders.GetFolderTrash(folder.Id));
        }

    }
}