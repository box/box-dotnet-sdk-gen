using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class SearchManagerTests {
        public BoxClient client { get; }

        public SearchManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateMetaDataQueryExecuteRead() {
            string templateKey = string.Concat("key", Utils.GetUUID());
            MetadataTemplate template = await client.MetadataTemplates.CreateMetadataTemplateAsync(requestBody: new CreateMetadataTemplateRequestBody(scope: "enterprise", displayName: templateKey) { TemplateKey = templateKey, Fields = Array.AsReadOnly(new [] {new CreateMetadataTemplateRequestBodyFieldsField(type: CreateMetadataTemplateRequestBodyFieldsTypeField.MultiSelect, key: "testColor", displayName: "testColor") { Options = Array.AsReadOnly(new [] {new CreateMetadataTemplateRequestBodyFieldsOptionsField(key: "red"),new CreateMetadataTemplateRequestBodyFieldsOptionsField(key: "green"),new CreateMetadataTemplateRequestBodyFieldsOptionsField(key: "blue")}) }}) });
            Assert.IsTrue(template.TemplateKey == templateKey);
            Files files = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 10)));
            FileFull file = NullableUtils.Unwrap(files.Entries)[0];
            MetadataFull metadata = await client.FileMetadata.CreateFileMetadataByIdAsync(fileId: file.Id, scope: CreateFileMetadataByIdScope.Enterprise, templateKey: templateKey, requestBody: new Dictionary<string, object>() { { "testColor", Array.AsReadOnly(new [] {"red","blue"}) } });
            Assert.IsTrue(metadata.Template == templateKey);
            Assert.IsTrue(metadata.Scope == template.Scope);
            string searchFrom = string.Concat(NullableUtils.Unwrap(template.Scope), ".", template.TemplateKey);
            MetadataQueryResults query = await client.Search.SearchByMetadataQueryAsync(requestBody: new MetadataQuery(ancestorFolderId: "0", from: searchFrom) { Query = "testColor = :value", QueryParams = new Dictionary<string, object>() { { "value", Array.AsReadOnly(new [] {"red","blue"}) } } });
            Assert.IsTrue(NullableUtils.Unwrap(query.Entries).Count >= 0);
            await client.MetadataTemplates.DeleteMetadataTemplateAsync(scope: DeleteMetadataTemplateScope.Enterprise, templateKey: template.TemplateKey);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id);
        }

    }
}