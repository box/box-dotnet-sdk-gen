using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class FoldersManagerTests {
        public BoxClient client { get; }

        public FoldersManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetFolderInfo() {
            FolderFull rootFolder = await client.Folders.GetFolderByIdAsync(folderId: "0").ConfigureAwait(false);
            Assert.IsTrue(rootFolder.Id == "0");
            Assert.IsTrue(rootFolder.Name == "All Files");
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetFolderFullInfoWithExtraFields() {
            FolderFull rootFolder = await client.Folders.GetFolderByIdAsync(folderId: "0", queryParams: new GetFolderByIdQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"has_collaborations","tags"}) }).ConfigureAwait(false);
            Assert.IsTrue(rootFolder.Id == "0");
            Assert.IsTrue(rootFolder.HasCollaborations == false);
            int tagsLength = rootFolder.Tags!.Count;
            Assert.IsTrue(tagsLength == 0);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateAndDeleteFolder() {
            string newFolderName = Utils.GetUUID();
            FolderFull newFolder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBodyArg(name: newFolderName, parent: new CreateFolderRequestBodyArgParentField(id: "0"))).ConfigureAwait(false);
            FolderFull createdFolder = await client.Folders.GetFolderByIdAsync(folderId: newFolder.Id).ConfigureAwait(false);
            Assert.IsTrue(createdFolder.Name == newFolderName);
            await client.Folders.DeleteFolderByIdAsync(folderId: newFolder.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.Folders.GetFolderByIdAsync(folderId: newFolder.Id).ConfigureAwait(false));
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestUpdateFolder() {
            string folderToUpdateName = Utils.GetUUID();
            FolderFull folderToUpdate = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBodyArg(name: folderToUpdateName, parent: new CreateFolderRequestBodyArgParentField(id: "0"))).ConfigureAwait(false);
            string updatedName = Utils.GetUUID();
            FolderFull updatedFolder = await client.Folders.UpdateFolderByIdAsync(folderId: folderToUpdate.Id, requestBody: new UpdateFolderByIdRequestBodyArg() { Name = updatedName, Description = "Updated description" }).ConfigureAwait(false);
            Assert.IsTrue(updatedFolder.Name == updatedName);
            Assert.IsTrue(updatedFolder.Description == "Updated description");
            await client.Folders.DeleteFolderByIdAsync(folderId: updatedFolder.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCopyMoveFolderAndListFolderItems() {
            string folderOriginName = Utils.GetUUID();
            FolderFull folderOrigin = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBodyArg(name: folderOriginName, parent: new CreateFolderRequestBodyArgParentField(id: "0"))).ConfigureAwait(false);
            string copiedFolderName = Utils.GetUUID();
            FolderFull copiedFolder = await client.Folders.CopyFolderAsync(folderId: folderOrigin.Id, requestBody: new CopyFolderRequestBodyArg(parent: new CopyFolderRequestBodyArgParentField(id: "0")) { Name = copiedFolderName }).ConfigureAwait(false);
            Assert.IsTrue(copiedFolder.Parent!.Id == "0");
            string movedFolderName = Utils.GetUUID();
            FolderFull movedFolder = await client.Folders.UpdateFolderByIdAsync(folderId: copiedFolder.Id, requestBody: new UpdateFolderByIdRequestBodyArg() { Parent = new UpdateFolderByIdRequestBodyArgParentField() { Id = folderOrigin.Id }, Name = movedFolderName }).ConfigureAwait(false);
            Assert.IsTrue(movedFolder.Parent!.Id == folderOrigin.Id);
            Items folderItems = await client.Folders.GetFolderItemsAsync(folderId: folderOrigin.Id).ConfigureAwait(false);
            await client.Folders.DeleteFolderByIdAsync(folderId: movedFolder.Id).ConfigureAwait(false);
            await client.Folders.DeleteFolderByIdAsync(folderId: folderOrigin.Id).ConfigureAwait(false);
        }

    }
}