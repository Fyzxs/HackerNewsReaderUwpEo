using FluentAssertions;
using HackerNewsUwpEo.Jsons;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace HackerNewsUwpEo.Tests.Jsons
{
    [TestClass]
    public class NewtonSoftCachingJsonObjectTests
    {
        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTitleFromStream()
        {
            //Arrange
            JsonObject json = new NewtonSoftCachingJsonObject(new MemoryStream(Encoding.ASCII.GetBytes(@"{""title"":""The Title""}")));

            //Act
            string title = json.Value<string>("title");

            //Assert
            title.Should().Be("The Title");

        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTitleFromString()
        {
            //Arrange
            JsonObject json = new NewtonSoftCachingJsonObject(@"{""title"":""The Title""}");

            //Act
            string title = json.Value<string>("title");

            //Assert
            title.Should().Be("The Title");

        }

        [TestMethod, TestCategory("unit")]
        public void ShouldReturnTitleFromText()
        {
            //Arrange
            JsonObject json = new NewtonSoftCachingJsonObject(new FakeText(@"{""title"":""The Title""}"));

            //Act
            string title = json.Value<string>("title");

            //Assert
            title.Should().Be("The Title");

        }

        [TestMethod, TestCategory("unit")]
        public void ShouldParseOnce()
        {
            //Arrange
            JsonObject json = new NewtonSoftCachingJsonObject(new FakeText(() => @"{""title"":""The Title""}", () => throw new Exception("Called Multiple Times")));
            json.Value<string>("title");

            //Act
            Action action = () => json.Value<string>("title");

            //Assert
            action.ShouldNotThrow();

        }
    }
}