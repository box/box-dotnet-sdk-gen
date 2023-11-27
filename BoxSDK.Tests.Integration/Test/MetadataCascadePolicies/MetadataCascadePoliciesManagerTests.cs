using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using Box;
using Box.Managers;
using Box.Schemas;

namespace Box.Tests.Integration {
    [TestClass]
    public class MetadataCascadePoliciesManagerTests {
        public BoxClient client { get; }

        public MetadataCascadePoliciesManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestMetadataCascadePolicies() {
            string templateKey = string.Concat("key", Utils.GetUUID());
            await client.MetadataTemplates.CreateMetadataTemplateAsync(requestBody: new CreateMetadataTemplateRequestBodyArg(scope: "enterprise", displayName: templateKey) { TemplateKey = templateKey, Fields = Array.AsReadOnly(new [] {new CreateMetadataTemplateRequestBodyArgFieldsField(type: CreateMetadataTemplateRequestBodyArgFieldsFieldTypeField.String, key: "testName", displayName: "testName")}) }).ConfigureAwait(false);
            FolderFull folder = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            MetadataCascadePolicy cascadePolicy = await client.MetadataCascadePolicies.CreateMetadataCascadePolicyAsync(requestBody: new CreateMetadataCascadePolicyRequestBodyArg(folderId: folder.Id, scope: CreateMetadataCascadePolicyRequestBodyArgScopeField.Enterprise, templateKey: templateKey)).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(cascadePolicy.Type) == "metadata_cascade_policy");
            Assert.IsTrue(StringUtils.ToStringRepresentation(cascadePolicy.OwnerEnterprise!.Type!) == "enterprise");
            Assert.IsTrue(StringUtils.ToStringRepresentation(cascadePolicy.OwnerEnterprise!.Id!) == enterpriseId);
            Assert.IsTrue(StringUtils.ToStringRepresentation(cascadePolicy.Parent!.Type!) == "folder");
            Assert.IsTrue(cascadePolicy.Parent!.Id! == folder.Id);
            Assert.IsTrue(StringUtils.ToStringRepresentation(cascadePolicy.Scope!) == string.Concat("enterprise_", enterpriseId));
            Assert.IsTrue(cascadePolicy.TemplateKey! == templateKey);
            string cascadePolicyId = cascadePolicy.Id;
            MetadataCascadePolicy policyFromTheApi = await client.MetadataCascadePolicies.GetMetadataCascadePolicyByIdAsync(metadataCascadePolicyId: cascadePolicyId).ConfigureAwait(false);
            Assert.IsTrue(cascadePolicyId == policyFromTheApi.Id);
            MetadataCascadePolicies policies = await client.MetadataCascadePolicies.GetMetadataCascadePoliciesAsync(queryParams: new GetMetadataCascadePoliciesQueryParamsArg(folderId: folder.Id)).ConfigureAwait(false);
            Assert.IsTrue(policies.Entries!.Count == 1);
            await Assert.That.IsExceptionAsync(async() => await client.MetadataCascadePolicies.CreateMetadataCascadePolicyApplyAsync(metadataCascadePolicyId: cascadePolicyId, requestBody: new CreateMetadataCascadePolicyApplyRequestBodyArg(conflictResolution: CreateMetadataCascadePolicyApplyRequestBodyArgConflictResolutionField.Overwrite)).ConfigureAwait(false));
            await client.MetadataCascadePolicies.DeleteMetadataCascadePolicyByIdAsync(metadataCascadePolicyId: cascadePolicyId).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.MetadataCascadePolicies.GetMetadataCascadePolicyByIdAsync(metadataCascadePolicyId: cascadePolicyId).ConfigureAwait(false));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}