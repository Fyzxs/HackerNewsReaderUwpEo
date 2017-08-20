using FluentAssertions;
using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HackerNewsUwpEo.Tests.CactooSharp.Texts
{
    [TestClass]
    public class NotNullTests
    {
        [TestMethod]
        public void ShouldReturnInputAsString()
        {
            Text text = new TextOf("val");
            Text notNull = new NotNull(text);
            notNull.String().Should().Be("val");
        }
        [TestMethod]
        public void ShouldThrowExceptionForNullText()
        {
            Text notNull = new NotNull(null);
            Action action = () => notNull.String();
            action.ShouldThrowExactly<Exception>().WithMessage("NULL instead of a valid text");
        }
        [TestMethod]
        public void ShouldThrowExceptionForNullTextValue()
        {
            Text text = new TextOf((string)null);
            Text notNull = new NotNull(text);
            Action action = () => notNull.String();
            action.ShouldThrowExactly<Exception>().WithMessage("NULL instead of a valid result string");
        }
    }
}
