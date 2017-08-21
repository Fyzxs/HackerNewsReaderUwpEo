using FluentAssertions;
using HackerNewsUwpEo.Clients.Json;
using HackerNewsUwpEo.Jsons;
using HackerNewsUwpEo.Stories;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Stories
{
    [TestClass]
    public class ClientCacheStoryTests
    {
        [TestMethod, TestCategory("unit")]
        public async Task ShouldSetTitle()
        {

            //Arrange 
            FakeSetText fakeSetText = new FakeSetText();
            FakeJsonClient jsonClient = new FakeJsonClient();
            jsonClient.JsonObject(new FakeJsonObject(new Dictionary<string, object> { { "title", "The Title" } }));
            Story story = new ClientStory(jsonClient);

            //Act
            await story.TitleInto(fakeSetText);

            //Assert
            fakeSetText.Assert(val => val.Should().Be("The Title"));
        }
        [TestMethod, TestCategory("unit")]
        public async Task ShouldSetAuthor()
        {

            //Arrange 
            FakeSetText fakeSetText = new FakeSetText();
            FakeJsonClient jsonClient = new FakeJsonClient();
            jsonClient.JsonObject(new FakeJsonObject(new Dictionary<string, object> { { "by", "The Author" } }));
            Story story = new ClientStory(jsonClient);

            //Act
            await story.AuthorInto(fakeSetText);

            //Assert
            fakeSetText.Assert(val => val.Should().Be("The Author"));
        }
    }

    public class FakeJsonClient : JsonClient
    {
        private JsonObject _jsonObject;
        private JsonArray _jsonArray;
        public void JsonObject(JsonObject jsonObject) => _jsonObject = jsonObject;
        public void JsonArray(JsonArray jsonArray) => _jsonArray = jsonArray;

        public Task<JsonArray> JsonArray() => Task.FromResult(_jsonArray);

        public Task<JsonObject> JsonObject() => Task.FromResult(_jsonObject);
    }
}