using FluentAssertions;
using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Texts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HackerNewsUwpEo.Tests.CactooSharp.Texts
{
    [TestClass]
    public class DelayedTextTests
    {
        [TestMethod]
        public void ShouldReturnStringFromDelayed()
        {
            Text delayed = new DelayedText(() => "Don't Care");
            delayed.String().Should().Be("Don't Care");
        }

        [TestMethod]
        public void ShouldNotInvokeUntilAsString()
        {
            Text delayed = new DelayedText(() => throw new IOException("deal with it"));

            ((Action)(() => delayed.String())).ShouldThrowExactly<IOException>().WithMessage("deal with it");
        }
    }
}
