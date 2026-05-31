using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http.Json;

namespace Code2.Tests
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    [TestClass]
    public class TodoApiTests
    {
        private HttpClient client = null!;
        private const string BaseUrl = "http://localhost:5159";

        [TestInitialize]
        public void Setup()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);
        }

        [TestCleanup]
        public void Cleanup()
        {
            client.Dispose();
        }

        [TestMethod]
        public async Task GetAllTasks_ShouldReturnOk()
        {
            var response = await client.GetAsync("/Todo");

            Assert.IsTrue(response.IsSuccessStatusCode,
                $"Expected 200 OK but got {response.StatusCode}");
        }

        [TestMethod]
        public async Task CreateTask_ShouldReturnCreated()
        {
            var newTask = new TodoItem { Title = "Test Task " + DateTime.Now.Ticks };

            var response = await client.PostAsJsonAsync("/Todo", newTask);

            Assert.AreEqual(System.Net.HttpStatusCode.Created,
                response.StatusCode,
                "POST /Todo should return 201 Created");
        }

        [TestMethod]
        public async Task DeleteTask_ShouldReturnNoContent()
        {
            var newTask = new TodoItem { Title = "Task to delete " + DateTime.Now.Ticks };
            var createResponse = await client.PostAsJsonAsync("/Todo", newTask);
            var created = await createResponse.Content.ReadFromJsonAsync<TodoItem>();
            var deleteResponse = await client.DeleteAsync($"/Todo/{created!.Id}");

            Assert.AreEqual(System.Net.HttpStatusCode.NoContent,
                deleteResponse.StatusCode,
                "DELETE /Todo/{id} should return 204 NoContent");
        }
    }
}