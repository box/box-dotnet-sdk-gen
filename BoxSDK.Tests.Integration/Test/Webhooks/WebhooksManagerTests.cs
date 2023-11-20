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
    public class WebhooksManagerTests {
        public BoxClient client { get; }

        public WebhooksManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestWebhooksCrud() {
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBodyArg(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyArgParentField(id: "0"))).ConfigureAwait(false);
            Webhook webhook = await client.Webhooks.CreateWebhookAsync(requestBody: new CreateWebhookRequestBodyArg(target: new CreateWebhookRequestBodyArgTargetField() { Id = folder.Id, Type = CreateWebhookRequestBodyArgTargetFieldTypeField.Folder }, address: "https://example.com/new-webhook", triggers: Array.AsReadOnly(new [] {CreateWebhookRequestBodyArgTriggersField.FileUploaded}))).ConfigureAwait(false);
            Assert.IsTrue(webhook.Target!.Id == folder.Id);
            Assert.IsTrue(StringUtils.ToStringRepresentation(webhook.Target!.Type) == "folder");
            Assert.IsTrue(webhook.Triggers!.Count == Array.AsReadOnly(new [] {"FILE.UPLOADED"}).Count);
            Assert.IsTrue(webhook.Address == "https://example.com/new-webhook");
            Webhooks webhooks = await client.Webhooks.GetWebhooksAsync().ConfigureAwait(false);
            Assert.IsTrue(webhooks.Entries!.Count > 0);
            Webhook webhookFromApi = await client.Webhooks.GetWebhookByIdAsync(webhookId: webhook.Id!).ConfigureAwait(false);
            Assert.IsTrue(webhook.Id == webhookFromApi.Id);
            Assert.IsTrue(webhook.Target!.Id == webhookFromApi.Target!.Id);
            Assert.IsTrue(webhook.Address == webhookFromApi.Address);
            Webhook updatedWebhook = await client.Webhooks.UpdateWebhookByIdAsync(webhookId: webhook.Id!, requestBody: new UpdateWebhookByIdRequestBodyArg() { Address = "https://example.com/updated-webhook" }).ConfigureAwait(false);
            Assert.IsTrue(updatedWebhook.Id == webhook.Id);
            Assert.IsTrue(updatedWebhook.Address == "https://example.com/updated-webhook");
            await client.Webhooks.DeleteWebhookByIdAsync(webhookId: webhook.Id!).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.Webhooks.DeleteWebhookByIdAsync(webhookId: webhook.Id!).ConfigureAwait(false));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}