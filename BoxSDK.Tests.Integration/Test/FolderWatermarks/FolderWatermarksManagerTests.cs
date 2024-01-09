using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class FolderWatermarksManagerTests {
        public BoxClient client { get; }

        public FolderWatermarksManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetDeleteFolderWatermark() {
            string folderName = Utils.GetUUID();
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: folderName, parent: new CreateFolderRequestBodyParentField(id: "0"))).ConfigureAwait(false);
            Watermark createdWatermark = await client.FolderWatermarks.UpdateFolderWatermarkAsync(folderId: folder.Id, requestBody: new UpdateFolderWatermarkRequestBody(watermark: new UpdateFolderWatermarkRequestBodyWatermarkField(imprint: UpdateFolderWatermarkRequestBodyWatermarkImprintField.Default))).ConfigureAwait(false);
            Watermark watermark = await client.FolderWatermarks.GetFolderWatermarkAsync(folderId: folder.Id).ConfigureAwait(false);
            await client.FolderWatermarks.DeleteFolderWatermarkAsync(folderId: folder.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FolderWatermarks.GetFolderWatermarkAsync(folderId: folder.Id).ConfigureAwait(false));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}