using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class SignRequestsManagerTests {
        public BoxClient client { get; }

        public SignRequestsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetCancelAndListSignRequest() {
            string signerEmail = string.Concat(Utils.GetUUID(), "@box.com");
            FileFull fileToSign = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            FolderFull destinationFolder = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            SignRequest createdSignRequest = await client.SignRequests.CreateSignRequestAsync(requestBody: new SignRequestCreateRequest(signers: Array.AsReadOnly(new [] {new SignRequestCreateSigner() { Email = signerEmail }}), parentFolder: new FolderMini(id: destinationFolder.Id, type: FolderBaseTypeField.Folder)) { SourceFiles = Array.AsReadOnly(new [] {new FileBase(id: fileToSign.Id, type: FileBaseTypeField.File)}) }).ConfigureAwait(false);
            Assert.IsTrue(createdSignRequest.SignFiles!.Files![0].Name == fileToSign.Name);
            Assert.IsTrue(createdSignRequest.Signers![1].Email == signerEmail);
            Assert.IsTrue(createdSignRequest.ParentFolder.Id == destinationFolder.Id);
            SignRequest newSignRequest = await client.SignRequests.GetSignRequestByIdAsync(signRequestId: createdSignRequest.Id!).ConfigureAwait(false);
            Assert.IsTrue(newSignRequest.SignFiles!.Files![0].Name == fileToSign.Name);
            Assert.IsTrue(newSignRequest.Signers![1].Email == signerEmail);
            Assert.IsTrue(newSignRequest.ParentFolder.Id == destinationFolder.Id);
            SignRequest cancelledSignRequest = await client.SignRequests.CancelSignRequestAsync(signRequestId: createdSignRequest.Id!).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(cancelledSignRequest.Status) == "cancelled");
            SignRequests signRequests = await client.SignRequests.GetSignRequestsAsync().ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(signRequests.Entries![0].Type!) == "sign-request");
            await client.Folders.DeleteFolderByIdAsync(folderId: destinationFolder.Id, queryParams: new DeleteFolderByIdQueryParamsArg() { Recursive = true }).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(fileId: fileToSign.Id).ConfigureAwait(false);
        }

    }
}