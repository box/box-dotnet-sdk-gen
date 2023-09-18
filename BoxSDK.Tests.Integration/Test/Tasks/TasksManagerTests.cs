using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class TasksManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public TasksManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateUpdateGetDeleteTask() {
            Files files = await client.Uploads.UploadFile(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: Utils.GenerateByteStream(10)));
            File file = files.Entries[0];
            Task task = await client.Tasks.CreateTask(new CreateTaskRequestBodyArg(item: new CreateTaskRequestBodyArgItemField() { Type = CreateTaskRequestBodyArgItemFieldTypeField.File, Id = file.Id }) { Message = "test message", DueAt = "2035-01-01T00:00:00Z", Action = CreateTaskRequestBodyArgActionField.Review, CompletionRule = CreateTaskRequestBodyArgCompletionRuleField.AllAssignees });
            Assert.IsTrue(task.Message == "test message");
            Assert.IsTrue(task.Item.Id == file.Id);
            Task taskById = await client.Tasks.GetTaskById(task.Id);
            Assert.IsTrue(taskById.Id == task.Id);
            Tasks taskOnFile = await client.Tasks.GetFileTasks(file.Id);
            Assert.IsTrue(taskOnFile.TotalCount == 1);
            Task updatedTask = await client.Tasks.UpdateTaskById(task.Id, new UpdateTaskByIdRequestBodyArg() { Message = "updated message" });
            Assert.IsTrue(updatedTask.Message == "updated message");
            await client.Tasks.DeleteTaskById(task.Id);
            await client.Files.DeleteFileById(file.Id);
        }

    }
}