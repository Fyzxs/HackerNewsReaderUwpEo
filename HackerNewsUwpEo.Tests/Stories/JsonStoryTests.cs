using FluentAssertions;
using HackerNewsUwpEo.Stories;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Stories
{
    [TestClass]
    public class JsonStoryTests
    {
        [TestMethod, TestCategory("unit")]
        public async Task ShouldSetTitle()
        {

            //Arrange 
            FakeSetText fakeSetText = new FakeSetText();
            Story story = new JsonStory(new FakeJsonObject(new Dictionary<string, object> { { "title", "The Title" } }));

            //Act
            await story.TitleInto(fakeSetText);

            //Assert
            fakeSetText.Assert(val => val.Should().Be("The Title"));
        }
    }
}