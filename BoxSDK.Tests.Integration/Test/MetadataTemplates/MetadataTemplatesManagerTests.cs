using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class MetadataTemplatesManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public MetadataTemplatesManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestMetadataTemplates() {
            string templateKey = string.Concat("key", Utils.GetUUID());
            MetadataTemplate template = await client.MetadataTemplates.CreateMetadataTemplateSchemaAsync(new CreateMetadataTemplateSchemaRequestBodyArg(scope: "enterprise", displayName: templateKey) { TemplateKey = templateKey, Fields = Array.AsReadOnly(new [] {new CreateMetadataTemplateSchemaRequestBodyArgFieldsField(type: CreateMetadataTemplateSchemaRequestBodyArgFieldsFieldTypeField.String, key: "testName", displayName: "testName")}) }).ConfigureAwait(false);
            Assert.IsTrue(template.TemplateKey == templateKey);
            Assert.IsTrue(template.DisplayName == templateKey);
            Assert.IsTrue(template.Fields.Count == 1);
            Assert.IsTrue(template.Fields[0].Key == "testName");
            Assert.IsTrue(template.Fields[0].DisplayName == "testName");
            MetadataTemplate getMetadataTemplate = await client.MetadataTemplates.GetMetadataTemplateByIdAsync(template.Id).ConfigureAwait(false);
            Assert.IsTrue(getMetadataTemplate.Id == template.Id);
            MetadataTemplate getMetadataTemplateSchema = await client.MetadataTemplates.GetMetadataTemplateSchemaAsync(GetMetadataTemplateSchemaScopeArg.Enterprise, template.TemplateKey).ConfigureAwait(false);
            Assert.IsTrue(getMetadataTemplateSchema.Id == template.Id);
            MetadataTemplates enterpriseMetadataTemplates = await client.MetadataTemplates.GetMetadataTemplateEnterpriseAsync().ConfigureAwait(false);
            Assert.IsTrue(enterpriseMetadataTemplates.Entries.Count > 0);
            MetadataTemplates globalMetadataTemplates = await client.MetadataTemplates.GetMetadataTemplateGlobalAsync().ConfigureAwait(false);
            Assert.IsTrue(globalMetadataTemplates.Entries.Count > 0);
            await client.MetadataTemplates.DeleteMetadataTemplateSchemaAsync(DeleteMetadataTemplateSchemaScopeArg.Enterprise, template.TemplateKey).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.MetadataTemplates.DeleteMetadataTemplateSchemaAsync(DeleteMetadataTemplateSchemaScopeArg.Enterprise, template.TemplateKey).ConfigureAwait(false));
        }

    }
}