using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using NullableExtensions;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class MetadataTemplatesManagerTests {
        public BoxClient client { get; }

        public MetadataTemplatesManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestMetadataTemplates() {
            string templateKey = string.Concat("key", Utils.GetUUID());
            MetadataTemplate template = await client.MetadataTemplates.CreateMetadataTemplateAsync(requestBody: new CreateMetadataTemplateRequestBody(scope: "enterprise", displayName: templateKey) { TemplateKey = templateKey, Fields = Array.AsReadOnly(new [] {new CreateMetadataTemplateRequestBodyFieldsField(type: CreateMetadataTemplateRequestBodyFieldsTypeField.String, key: "testName", displayName: "testName")}) }).ConfigureAwait(false);
            Assert.IsTrue(template.TemplateKey == templateKey);
            Assert.IsTrue(template.DisplayName == templateKey);
            Assert.IsTrue(NullableUtils.Unwrap(template.Fields).Count == 1);
            Assert.IsTrue(NullableUtils.Unwrap(template.Fields)[0].Key == "testName");
            Assert.IsTrue(NullableUtils.Unwrap(template.Fields)[0].DisplayName == "testName");
            MetadataTemplate updatedTemplate = await client.MetadataTemplates.UpdateMetadataTemplateAsync(scope: UpdateMetadataTemplateScope.Enterprise, templateKey: templateKey, requestBody: Array.AsReadOnly(new [] {new UpdateMetadataTemplateRequestBody(op: UpdateMetadataTemplateRequestBodyOpField.AddField) { FieldKey = "newfieldname", Data = new Dictionary<string, string>() { { "type", "string" }, { "displayName", "newFieldName" } } }})).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(updatedTemplate.Fields).Count == 2);
            Assert.IsTrue(NullableUtils.Unwrap(updatedTemplate.Fields)[1].Key == "newfieldname");
            Assert.IsTrue(NullableUtils.Unwrap(updatedTemplate.Fields)[1].DisplayName == "newFieldName");
            MetadataTemplate getMetadataTemplate = await client.MetadataTemplates.GetMetadataTemplateByIdAsync(templateId: template.Id).ConfigureAwait(false);
            Assert.IsTrue(getMetadataTemplate.Id == template.Id);
            MetadataTemplate getMetadataTemplateSchema = await client.MetadataTemplates.GetMetadataTemplateAsync(scope: GetMetadataTemplateScope.Enterprise, templateKey: NullableUtils.Unwrap(template.TemplateKey)).ConfigureAwait(false);
            Assert.IsTrue(getMetadataTemplateSchema.Id == template.Id);
            MetadataTemplates enterpriseMetadataTemplates = await client.MetadataTemplates.GetEnterpriseMetadataTemplatesAsync().ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(enterpriseMetadataTemplates.Entries).Count > 0);
            MetadataTemplates globalMetadataTemplates = await client.MetadataTemplates.GetGlobalMetadataTemplatesAsync().ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(globalMetadataTemplates.Entries).Count > 0);
            await client.MetadataTemplates.DeleteMetadataTemplateAsync(scope: DeleteMetadataTemplateScope.Enterprise, templateKey: NullableUtils.Unwrap(template.TemplateKey)).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.MetadataTemplates.DeleteMetadataTemplateAsync(scope: DeleteMetadataTemplateScope.Enterprise, templateKey: NullableUtils.Unwrap(template.TemplateKey)).ConfigureAwait(false));
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetMetadataTemplateByInstance() {
            FileFull file = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            string templateKey = string.Concat("key", Utils.GetUUID());
            MetadataTemplate template = await client.MetadataTemplates.CreateMetadataTemplateAsync(requestBody: new CreateMetadataTemplateRequestBody(scope: "enterprise", displayName: templateKey) { TemplateKey = templateKey, Fields = Array.AsReadOnly(new [] {new CreateMetadataTemplateRequestBodyFieldsField(type: CreateMetadataTemplateRequestBodyFieldsTypeField.String, key: "testName", displayName: "testName")}) }).ConfigureAwait(false);
            MetadataFull createdMetadataInstance = await client.FileMetadata.CreateFileMetadataByIdAsync(fileId: file.Id, scope: CreateFileMetadataByIdScope.Enterprise, templateKey: templateKey, requestBody: new Dictionary<string, string>() { { "testName", "xyz" } }).ConfigureAwait(false);
            MetadataTemplates metadataTemplates = await client.MetadataTemplates.GetMetadataTemplatesByInstanceIdAsync(queryParams: new GetMetadataTemplatesByInstanceIdQueryParams(metadataInstanceId: NullableUtils.Unwrap(createdMetadataInstance.Id))).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(metadataTemplates.Entries).Count == 1);
            Assert.IsTrue(NullableUtils.Unwrap(metadataTemplates.Entries)[0].DisplayName == templateKey);
            Assert.IsTrue(NullableUtils.Unwrap(metadataTemplates.Entries)[0].TemplateKey == templateKey);
            await client.FileMetadata.DeleteFileMetadataByIdAsync(fileId: file.Id, scope: DeleteFileMetadataByIdScope.Enterprise, templateKey: templateKey).ConfigureAwait(false);
            await client.MetadataTemplates.DeleteMetadataTemplateAsync(scope: DeleteMetadataTemplateScope.Enterprise, templateKey: NullableUtils.Unwrap(template.TemplateKey)).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

    }
}