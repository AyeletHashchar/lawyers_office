using Microsoft.AspNetCore.Mvc.Testing;
using webApi;

namespace TestProject
{
    public class basicTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public basicTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/Cities/getAll")]
        [InlineData("/api/Cities/getById/1")]
        [InlineData("/api/ActionPatterns/getAll")]
        [InlineData("/api/ActionPatterns/getById/1")]
        [InlineData("/api/Actions/getAll")]
        [InlineData("/api/Actions/getById/1")]
        [InlineData("/api/FilePatterns/getAll")]
        [InlineData("/api/FilePatterns/getById/1")]
        [InlineData("/api/Files/getAll")]
        [InlineData("/api/Files/getById")]
        [InlineData("/api/Links/getAll")]
        [InlineData("/api/Links/getById/1")]
        [InlineData("/api/Payments/getAll")]
        [InlineData("/api/Payments/getById/1002")]
        public async Task GetHttpRequest(string url)
        {
            //Arrange
            var client = _factory.CreateClient();
            //Act
            var response = await client.GetAsync(url);
            //Assert

            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }

        [Theory]
        [InlineData("/api/Cities/post", null)]
        [InlineData("/api/ActionPatterns/post", null)]
        [InlineData("/api/Actions/post", null)]
        [InlineData("/api/FilePatterns/post", null)]
        [InlineData("/api/Files/post", null)]
        [InlineData("/api/Links/post", null)]
        [InlineData("/api/Payments/post", null)]
        public async Task PostHttpRequest(string url, HttpContent content)
        {
            //Arrange
            var client = _factory.CreateClient();
            //Act
            var response = await client.PostAsync(url, content);
            //Assert
            Assert.True(response.StatusCode == System.Net.HttpStatusCode.UnsupportedMediaType,
                response.Content.Headers.ContentType.ToString());
        }

        [Theory]
        [InlineData("/api/Cities/put", null)]
        [InlineData("/api/ActionPatterns/put", null)]
        [InlineData("/api/Actions/put", null)]
        [InlineData("/api/FilePatterns/put", null)]
        [InlineData("/api/Files/put", null)]
        [InlineData("/api/Links/put", null)]
        [InlineData("/api/Payments/put", null)]
        public async Task PutHttpRequest(string url, HttpContent content)
        {
            //Arrange
            var client = _factory.CreateClient();
            //Act
            var response = await client.PutAsync(url, content);
            //Assert
            Assert.True(response.StatusCode == System.Net.HttpStatusCode.UnsupportedMediaType,
                response.Content.Headers.ContentType.ToString());
        }

        [Theory]
        [InlineData("/api/Cities/delete/0")]
        [InlineData("/api/ActionPatterns/delete/0")]
        [InlineData("/api/Actions/delete/0")]
        [InlineData("/api/FilePatterns/delete/0")]
        [InlineData("/api/Files/delete/0")]
        [InlineData("/api/Links/delete/0")]
        [InlineData("/api/Payments/delete/0")]
        public async Task DeleteHttpRequest(string url)
        {
            //Arrange
            var client = _factory.CreateClient();
            //Act
            var response = await client.DeleteAsync(url);
            //Assert

            Assert.True(response.StatusCode == System.Net.HttpStatusCode.NotFound,
                response.Content.Headers.ContentType.ToString());
        }
    }
}
