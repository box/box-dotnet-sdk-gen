using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class AiManagerTests {
        public BoxClient client { get; }

        public AiManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestAskAiSingleItem() {
            FileFull fileToAsk = await new CommonsManager().UploadNewFileAsync();
            AiResponse response = await client.Ai.CreateAiAskAsync(requestBody: new AiAsk(mode: AiAskModeField.SingleItemQa, prompt: "which direction sun rises", items: Array.AsReadOnly(new [] {new AiAskItemsField(id: fileToAsk.Id, type: AiAskItemsTypeField.File) { Content = "Sun rises in the East" }})));
            Assert.IsTrue(response.Answer.Contains("East"));
            Assert.IsTrue(response.CompletionReason == "done");
            await client.Files.DeleteFileByIdAsync(fileId: fileToAsk.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAskAiMultipleItems() {
            FileFull fileToAsk1 = await new CommonsManager().UploadNewFileAsync();
            FileFull fileToAsk2 = await new CommonsManager().UploadNewFileAsync();
            AiResponse response = await client.Ai.CreateAiAskAsync(requestBody: new AiAsk(mode: AiAskModeField.MultipleItemQa, prompt: "Which direction sun rises?", items: Array.AsReadOnly(new [] {new AiAskItemsField(id: fileToAsk1.Id, type: AiAskItemsTypeField.File) { Content = "Earth goes around the sun" },new AiAskItemsField(id: fileToAsk2.Id, type: AiAskItemsTypeField.File) { Content = "Sun rises in the East in the morning" }})));
            Assert.IsTrue(response.Answer.Contains("East"));
            Assert.IsTrue(response.CompletionReason == "done");
            await client.Files.DeleteFileByIdAsync(fileId: fileToAsk1.Id);
            await client.Files.DeleteFileByIdAsync(fileId: fileToAsk2.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAiTextGenWithDialogueHistory() {
            FileFull fileToAsk = await new CommonsManager().UploadNewFileAsync();
            AiResponse response = await client.Ai.CreateAiTextGenAsync(requestBody: new AiTextGen(prompt: "Parapharse the document.s", items: Array.AsReadOnly(new [] {new AiTextGenItemsField() { Id = fileToAsk.Id, Type = AiTextGenItemsTypeField.File, Content = "The Earth goes around the sun. Sun rises in the East in the morning." }})) { DialogueHistory = Array.AsReadOnly(new [] {new AiTextGenDialogueHistoryField() { Prompt = "What does the earth go around?", Answer = "The sun", CreatedAt = Utils.DateTimeFromString(dateTime: "2021-01-01T00:00:00Z") },new AiTextGenDialogueHistoryField() { Prompt = "On Earth, where does the sun rise?", Answer = "East", CreatedAt = Utils.DateTimeFromString(dateTime: "2021-01-01T00:00:00Z") }}) });
            Assert.IsTrue(response.Answer.Contains("sun"));
            Assert.IsTrue(response.CompletionReason == "done");
            await client.Files.DeleteFileByIdAsync(fileId: fileToAsk.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGettingAiAskAgentConfig() {
            AiAgentAskOrAiAgentTextGen aiAskConfig = await client.Ai.GetAiAgentDefaultConfigAsync(queryParams: new GetAiAgentDefaultConfigQueryParams(mode: GetAiAgentDefaultConfigQueryParamsModeField.Ask) { Language = "ja-JP" });
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGettingAiTextGenAgentConfig() {
            AiAgentAskOrAiAgentTextGen aiTextGenConfig = await client.Ai.GetAiAgentDefaultConfigAsync(queryParams: new GetAiAgentDefaultConfigQueryParams(mode: GetAiAgentDefaultConfigQueryParamsModeField.TextGen) { Language = "en-US" });
        }

    }
}