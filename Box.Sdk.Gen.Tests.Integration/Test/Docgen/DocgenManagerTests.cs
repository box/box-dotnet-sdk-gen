using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class DocgenManagerTests {
        public BoxClient client { get; }

        public DocgenManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestDocgenBatchAndJobs() {
            FileFull uploadedFile = await new CommonsManager().UploadNewFileAsync();
            FolderFull folder = await new CommonsManager().CreateNewFolderAsync();
            DocGenTemplateBaseV2025R0 createdDocgenTemplate = await client.DocgenTemplate.CreateDocgenTemplateV2025R0Async(requestBody: new DocGenTemplateCreateRequestV2025R0(file: new FileReferenceV2025R0(id: uploadedFile.Id)));
            DocGenBatchBaseV2025R0 docgenBatch = await client.Docgen.CreateDocgenBatchV2025R0Async(requestBody: new DocGenBatchCreateRequestV2025R0(file: new FileReferenceV2025R0(id: uploadedFile.Id), inputSource: "api", destinationFolder: new DocGenBatchCreateRequestV2025R0DestinationFolderField(id: folder.Id), outputType: "pdf", documentGenerationData: Array.AsReadOnly(new [] {new DocGenDocumentGenerationDataV2025R0(generatedFileName: "test", userInput: new Dictionary<string, object>() { { "abc", "xyz" } })})));
            Assert.IsTrue(docgenBatch.Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(docgenBatch.Type?.Value) == "docgen_batch");
            DocGenJobsV2025R0 docgenBatchJobs = await client.Docgen.GetDocgenBatchJobByIdV2025R0Async(batchId: docgenBatch.Id);
            Assert.IsTrue(NullableUtils.Unwrap(docgenBatchJobs.Entries).Count >= 1);
            Assert.IsTrue(NullableUtils.Unwrap(docgenBatchJobs.Entries)[0].Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(docgenBatchJobs.Entries)[0].Type) == "docgen_job");
            Assert.IsTrue(NullableUtils.Unwrap(docgenBatchJobs.Entries)[0].OutputType == "pdf");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(docgenBatchJobs.Entries)[0].Status) != "");
            Assert.IsTrue(NullableUtils.Unwrap(docgenBatchJobs.Entries)[0].TemplateFile.Id == uploadedFile.Id);
            Assert.IsTrue(NullableUtils.Unwrap(docgenBatchJobs.Entries)[0].Batch.Id == docgenBatch.Id);
            DocGenJobsFullV2025R0 docgenJobs = await client.Docgen.GetDocgenJobsV2025R0Async();
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries).Count >= 1);
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries)[0].Batch.Id != "");
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries)[0].CreatedBy.Id != "");
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries)[0].Enterprise.Id != "");
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries)[0].Id != "");
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries)[0].OutputType != "");
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries)[0].Source != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(docgenJobs.Entries)[0].Status) != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(docgenJobs.Entries)[0].TemplateFile.Type) == "file");
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries)[0].TemplateFile.Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(docgenJobs.Entries)[0].TemplateFileVersion.Type) == "file_version");
            Assert.IsTrue(NullableUtils.Unwrap(docgenJobs.Entries)[0].TemplateFileVersion.Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(docgenJobs.Entries)[0].Type) == "docgen_job");
            DocGenJobV2025R0 docgenJob = await client.Docgen.GetDocgenJobByIdV2025R0Async(jobId: NullableUtils.Unwrap(docgenJobs.Entries)[0].Id);
            Assert.IsTrue(docgenJob.Batch.Id != "");
            Assert.IsTrue(docgenJob.Id != "");
            Assert.IsTrue(docgenJob.OutputType != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(docgenJob.Status?.Value) != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(docgenJob.TemplateFile.Type?.Value) == "file");
            Assert.IsTrue(docgenJob.TemplateFile.Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(docgenJob.TemplateFileVersion.Type?.Value) == "file_version");
            Assert.IsTrue(docgenJob.TemplateFileVersion.Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(docgenJob.Type?.Value) == "docgen_job");
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id);
            await client.Files.DeleteFileByIdAsync(fileId: uploadedFile.Id);
        }

    }
}