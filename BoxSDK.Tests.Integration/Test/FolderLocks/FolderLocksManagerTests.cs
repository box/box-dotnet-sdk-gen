using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class FolderLocksManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public FolderLocksManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestFolderLocks() {
            FolderFull folder = await client.Folders.CreateFolder(new CreateFolderRequestBodyArg(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyArgParentField(id: "0")));
            FolderLocks folderLocks = await client.FolderLocks.GetFolderLocks(new GetFolderLocksQueryParamsArg(folderId: folder.Id));
            Assert.IsTrue(folderLocks.Entries.Count == 0);
            FolderLock folderLock = await client.FolderLocks.CreateFolderLock(new CreateFolderLockRequestBodyArg(folder: new CreateFolderLockRequestBodyArgFolderField(id: folder.Id, type: "folder")) { LockedOperations = new CreateFolderLockRequestBodyArgLockedOperationsField(move: true, delete: true) });
            Assert.IsTrue(folderLock.Folder.Id == folder.Id);
            Assert.IsTrue(folderLock.LockedOperations.Move == true);
            Assert.IsTrue(folderLock.LockedOperations.Delete == true);
            await client.FolderLocks.DeleteFolderLockById(folderLock.Id);
            await Assert.ThrowsExceptionAsync<Exception>(async() => await client.FolderLocks.DeleteFolderLockById(folderLock.Id));
            FolderLocks newFolderLocks = await client.FolderLocks.GetFolderLocks(new GetFolderLocksQueryParamsArg(folderId: folder.Id));
            Assert.IsTrue(newFolderLocks.Entries.Count == 0);
            await client.Folders.DeleteFolderById(folder.Id);
        }

    }
}