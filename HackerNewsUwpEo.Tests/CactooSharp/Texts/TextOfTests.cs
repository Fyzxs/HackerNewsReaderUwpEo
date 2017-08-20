using FluentAssertions;
using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace HackerNewsUwpEo.Tests.CactooSharp.Texts
{
    [TestClass]
    public class TextOfTests
    {
        [TestMethod]
        public void ShouldReturnInputFromScalar()
        {
            Text value = new TextOf("Some ValueItem Here");
            value.String().Should().Be("Some ValueItem Here");
        }

        [TestMethod]
        public void ShouldReturnInputFromString()
        {
            Text value = new TextOf("Some ValueItem Here");
            value.String().Should().Be("Some ValueItem Here");
        }

        [TestMethod]
        public void ShouldReturnInputFromText()
        {
            Text value = new TextOf(new DelayedText(() => "Some ValueItem Here"));
            value.String().Should().Be("Some ValueItem Here");
        }

        [TestMethod]
        public void ShouldReturnStringOfBytes()
        {
            Text value = new TextOf(Encoding.ASCII.GetBytes("Some ValueItem Here"));
            value.String().Should().Be("Some ValueItem Here");
        }

        [TestMethod]
        public void ShouldReturnStringOfStream()
        {
            MemoryStream memoryStream = new MemoryStream(Encoding.ASCII.GetBytes("Some ValueItem Here"));
            Text value = new TextOf(memoryStream);
            value.String().Should().Be("Some ValueItem Here");
        }


    }
}
