using FluentAssertions;
using HackerNewsUwpEo.Stories;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Stories
{
    [TestClass]
    public class ClientStoryTests
    {
        [TestMethod, TestCategory("unit")]
        public async Task ShouldSetTitle()
        {

            //Arrange 
            FakeSetText fakeSetText = new FakeSetText();
            FakeStory fakeStory = new FakeStory().Title("The Title");
            Story story = new DefaultStory(fakeStory);

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
            FakeStory fakeStory = new FakeStory().Author("The Author");
            Story story = new DefaultStory(fakeStory);

            //Act
            await story.AuthorInto(fakeSetText);

            //Assert
            fakeSetText.Assert(val => val.Should().Be("The Author"));
        }
    }
}