using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using NullableExtensions;
using StringExtensions;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
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
            SignRequest createdSignRequest = await client.SignRequests.CreateSignRequestAsync(requestBody: new SignRequestCreateRequest(signers: Array.AsReadOnly(new [] {new SignRequestCreateSigner() { Email = signerEmail }}), parentFolder: new FolderMini(id: destinationFolder.Id, type: FolderBaseTypeField.Folder)) { PrefillTags = Array.AsReadOnly(new [] {new SignRequestPrefillTag() { DateValue = Utils.DateFromString(date: "2035-01-01"), DocumentTagId = "0" }}), SourceFiles = Array.AsReadOnly(new [] {new FileBase(id: fileToSign.Id, type: FileBaseTypeField.File)}) }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(NullableUtils.Unwrap(createdSignRequest.SignFiles).Files)[0].Name == fileToSign.Name);
            Assert.IsTrue(NullableUtils.Unwrap(createdSignRequest.Signers)[1].Email == signerEmail);
            Assert.IsTrue(createdSignRequest.ParentFolder.Id == destinationFolder.Id);
            Assert.IsTrue(Utils.DateToString(date: NullableUtils.Unwrap(createdSignRequest.PrefillTags[0].DateValue)) == "2035-01-01");
            SignRequest newSignRequest = await client.SignRequests.GetSignRequestByIdAsync(signRequestId: NullableUtils.Unwrap(createdSignRequest.Id)).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(NullableUtils.Unwrap(newSignRequest.SignFiles).Files)[0].Name == fileToSign.Name);
            Assert.IsTrue(NullableUtils.Unwrap(newSignRequest.Signers)[1].Email == signerEmail);
            Assert.IsTrue(newSignRequest.ParentFolder.Id == destinationFolder.Id);
            SignRequest cancelledSignRequest = await client.SignRequests.CancelSignRequestAsync(signRequestId: NullableUtils.Unwrap(createdSignRequest.Id)).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(cancelledSignRequest.Status) == "cancelled");
            SignRequests signRequests = await client.SignRequests.GetSignRequestsAsync().ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(NullableUtils.Unwrap(signRequests.Entries)[0].Type)) == "sign-request");
            await client.Folders.DeleteFolderByIdAsync(folderId: destinationFolder.Id, queryParams: new DeleteFolderByIdQueryParams() { Recursive = true }).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(fileId: fileToSign.Id).ConfigureAwait(false);
        }

    }
}