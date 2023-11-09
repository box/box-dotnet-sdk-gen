using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using Box;
using Box.Schemas;

namespace Box.Tests.Integration {
    [TestClass]
    public class ZipDownloadsManagerTests {
        public BoxClient client { get; }

        public ZipDownloadsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestZipDownload() {
            File file1 = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            File file2 = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            FolderFull folder1 = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            System.IO.Stream zipStream = await client.ZipDownloads.DownloadZipAsync(new ZipDownloadRequest(items: Array.AsReadOnly(new [] {new ZipDownloadRequestItemsField(id: file1.Id, type: ZipDownloadRequestItemsFieldTypeField.File),new ZipDownloadRequestItemsField(id: file2.Id, type: ZipDownloadRequestItemsFieldTypeField.File),new ZipDownloadRequestItemsField(id: folder1.Id, type: ZipDownloadRequestItemsFieldTypeField.Folder)})) { DownloadFileName = "zip" }).ConfigureAwait(false);
            Assert.IsTrue(Utils.BufferEquals(await Utils.ReadByteStreamAsync(zipStream).ConfigureAwait(false), Utils.GenerateByteBuffer(10)) == false);
            await client.Files.DeleteFileByIdAsync(file1.Id).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(file2.Id).ConfigureAwait(false);
            await client.Folders.DeleteFolderByIdAsync(folder1.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestManualZipDownloadAndCheckStatus() {
            File file1 = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            File file2 = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            FolderFull folder1 = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            ZipDownload zipDownload = await client.ZipDownloads.CreateZipDownloadAsync(new ZipDownloadRequest(items: Array.AsReadOnly(new [] {new ZipDownloadRequestItemsField(id: file1.Id, type: ZipDownloadRequestItemsFieldTypeField.File),new ZipDownloadRequestItemsField(id: file2.Id, type: ZipDownloadRequestItemsFieldTypeField.File),new ZipDownloadRequestItemsField(id: folder1.Id, type: ZipDownloadRequestItemsFieldTypeField.Folder)})) { DownloadFileName = "zip" }).ConfigureAwait(false);
            Assert.IsTrue(zipDownload.DownloadUrl != "");
            Assert.IsTrue(zipDownload.StatusUrl != "");
            Assert.IsTrue(zipDownload.ExpiresAt != "");
            System.IO.Stream zipStream = await client.ZipDownloads.GetZipDownloadContentAsync(zipDownload.DownloadUrl!).ConfigureAwait(false);
            Assert.IsTrue(Utils.BufferEquals(await Utils.ReadByteStreamAsync(zipStream).ConfigureAwait(false), Utils.GenerateByteBuffer(10)) == false);
            ZipDownloadStatus zipDownloadStatus = await client.ZipDownloads.GetZipDownloadStatusAsync(zipDownload.StatusUrl!).ConfigureAwait(false);
            Assert.IsTrue(zipDownloadStatus.TotalFileCount == 2);
            Assert.IsTrue(zipDownloadStatus.DownloadedFileCount == 2);
            Assert.IsTrue(zipDownloadStatus.SkippedFileCount == 0);
            Assert.IsTrue(zipDownloadStatus.SkippedFolderCount == 0);
            Assert.IsTrue(StringUtils.ToStringRepresentation(zipDownloadStatus.State) != "failed");
            await client.Files.DeleteFileByIdAsync(file1.Id).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(file2.Id).ConfigureAwait(false);
            await client.Folders.DeleteFolderByIdAsync(folder1.Id).ConfigureAwait(false);
        }

    }
}