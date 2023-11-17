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
            Files uploadedFiles = await client.Uploads.UploadFileAsync(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: fileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: Utils.GenerateByteStream(10))).ConfigureAwait(false);
            FileFull file = uploadedFiles.Entries![0];
            Watermark createdWatermark = await client.FileWatermarks.UpdateFileWatermarkAsync(file.Id, new UpdateFileWatermarkRequestBodyArg(watermark: new UpdateFileWatermarkRequestBodyArgWatermarkField(imprint: UpdateFileWatermarkRequestBodyArgWatermarkFieldImprintField.Default))).ConfigureAwait(false);
            Watermark watermark = await client.FileWatermarks.GetFileWatermarkAsync(file.Id).ConfigureAwait(false);
            await client.FileWatermarks.DeleteFileWatermarkAsync(file.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FileWatermarks.GetFileWatermarkAsync(file.Id).ConfigureAwait(false));
            await client.Files.DeleteFileByIdAsync(file.Id).ConfigureAwait(false);
        }

    }
}