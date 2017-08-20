using FluentAssertions;
using HackerNewsUwpEo.Stories;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HackerNewsUwpEo.Tests.Stories
{
    [TestClass]
    public class JsonStoryTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldSetTitle()
        {

            //Arrange 
            FakeSetText fakeSetText = new FakeSetText();
            Story story = new JsonStory(new FakeJson(new Dictionary<string, object> { { "title", "The Title" } }));

            //Act
            story.TitleInto(fakeSetText);

            //Assert
            fakeSetText.Assert(val => val.Should().Be("The Title"));
        }
    }
}