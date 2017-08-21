using FluentAssertions;
using HackerNewsUwpEo.Stories;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests
{
    [TestClass]
    public class HighLevelTests
    {
        [TestMethod, TestCategory("functional")]
        public async Task ShouldMakeNetworkCall()
        {
            //Arrange
            FakeSetText fakeSetText = new FakeSetText();
            Story story = new DefaultStory("8863");

            //Act
            await story.TitleInto(fakeSetText);

            //Assert
            fakeSetText.Assert(val => val.Should().Be("My YC app: Dropbox - Throw away your USB drive"));
        }
    }
}
