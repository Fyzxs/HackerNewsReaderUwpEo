using FluentAssertions;
using HackerNewsUwpEo.Stories.Top;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Stories.Top
{
    [TestClass]
    public class ClientCacheTopStoriesTests
    {
        [TestMethod, TestCategory("unit")]
        public async Task ShouldReturnIdsInOrder()
        {
            //Arrange
            FakeJsonClient fakeJsonClient = new FakeJsonClient();
            fakeJsonClient.JsonArray(new FakeJsonArray(JArray.Parse("[123, 456, 789]")));
            TopStories stories = new ClientCacheTopStories(fakeJsonClient);

            //Act
            string first = await stories.NextId();
            string second = await stories.NextId();
            string third = await stories.NextId();

            //Assert
            first.Should().Be("123");
            second.Should().Be("456");
            third.Should().Be("789");
        }

        [TestMethod, TestCategory("unit")]
        public async Task ShouldReturnCount()
        {
            //Arrange 
            FakeJsonClient fakeJsonClient = new FakeJsonClient();
            fakeJsonClient.JsonArray(new FakeJsonArray(JArray.Parse("[123, 456, 789]")));
            TopStories stories = new ClientCacheTopStories(fakeJsonClient);

            //Act
            int count = await stories.Count();

            //Assert
            count.Should().Be(3);
        }
    }
}