using FluentAssertions;
using HackerNewsUwpEo.Stories.Top;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Stories.Top
{
    [TestClass]
    public class DefaultTopStoriesTests
    {
        [TestMethod, TestCategory("unit")]
        public async Task ShouldReturnIdsInOrder()
        {
            //Arrange 
            TopStories stories = new DefaultTopStories(new FakeTopStories(new List<string> { "123", "456", "789" }));

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
            TopStories stories = new DefaultTopStories(new FakeTopStories(new List<string> { "123", "456", "789" }));

            //Act
            int count = await stories.Count();

            //Assert
            count.Should().Be(3);
        }
    }
}