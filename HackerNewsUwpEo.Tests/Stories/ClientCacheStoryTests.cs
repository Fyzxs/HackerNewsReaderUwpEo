using FluentAssertions;
using HackerNewsUwpEo.Clients;
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
            Client client = new FakeClient(new FakeJsonObject(new Dictionary<string, object> { { "title", "The Title" } }));
            Story story = new ClientCacheStory(client);

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
            Client client = new FakeClient(new FakeJsonObject(new Dictionary<string, object> { { "by", "The Author" } }));
            Story story = new ClientCacheStory(client);

            //Act
            await story.AuthorInto(fakeSetText);

            //Assert
            fakeSetText.Assert(val => val.Should().Be("The Author"));
        }
    }
}