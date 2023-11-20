using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class FileWatermarksManagerTests {
        public BoxClient client { get; }

        public FileWatermarksManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetDeleteFileWatermark() {
            string fileName = string.Concat(Utils.GetUUID(), ".txt");
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: fileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: Utils.GenerateByteStream(size: 10))).ConfigureAwait(false);
            FileFull file = uploadedFiles.Entries![0];
            Watermark createdWatermark = await client.FileWatermarks.UpdateFileWatermarkAsync(fileId: file.Id, requestBody: new UpdateFileWatermarkRequestBodyArg(watermark: new UpdateFileWatermarkRequestBodyArgWatermarkField(imprint: UpdateFileWatermarkRequestBodyArgWatermarkFieldImprintField.Default))).ConfigureAwait(false);
            Watermark watermark = await client.FileWatermarks.GetFileWatermarkAsync(fileId: file.Id).ConfigureAwait(false);
            await client.FileWatermarks.DeleteFileWatermarkAsync(fileId: file.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FileWatermarks.GetFileWatermarkAsync(fileId: file.Id).ConfigureAwait(false));
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

    }
}