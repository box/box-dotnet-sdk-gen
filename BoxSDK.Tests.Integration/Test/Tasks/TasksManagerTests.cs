using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class TasksManagerTests {
        public BoxClient client { get; }

        public TasksManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateUpdateGetDeleteTask() {
            Files files = await client.Uploads.UploadFileAsync(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: Utils.GenerateByteStream(10))).ConfigureAwait(false);
            File file = files.Entries![0];
            Task task = await client.Tasks.CreateTaskAsync(new CreateTaskRequestBodyArg(item: new CreateTaskRequestBodyArgItemField() { Type = CreateTaskRequestBodyArgItemFieldTypeField.File, Id = file.Id }) { Message = "test message", DueAt = "2035-01-01T00:00:00Z", Action = CreateTaskRequestBodyArgActionField.Review, CompletionRule = CreateTaskRequestBodyArgCompletionRuleField.AllAssignees }).ConfigureAwait(false);
            Assert.IsTrue(task.Message == "test message");
            Assert.IsTrue(task.Item!.Id == file.Id);
            Task taskById = await client.Tasks.GetTaskByIdAsync(task.Id!).ConfigureAwait(false);
            Assert.IsTrue(taskById.Id == task.Id);
            Tasks taskOnFile = await client.Tasks.GetFileTasksAsync(file.Id).ConfigureAwait(false);
            Assert.IsTrue(taskOnFile.TotalCount == 1);
            Task updatedTask = await client.Tasks.UpdateTaskByIdAsync(task.Id!, new UpdateTaskByIdRequestBodyArg() { Message = "updated message" }).ConfigureAwait(false);
            Assert.IsTrue(updatedTask.Message == "updated message");
            await client.Tasks.DeleteTaskByIdAsync(task.Id!).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(file.Id).ConfigureAwait(false);
        }

    }
}