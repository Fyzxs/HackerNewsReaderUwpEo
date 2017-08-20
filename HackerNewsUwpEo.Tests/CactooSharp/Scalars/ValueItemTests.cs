using FluentAssertions;
using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Scalars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerNewsUwpEo.Tests.CactooSharp.Scalars
{
    [TestClass]
    public class ValueItemTests
    {
        [TestMethod]
        public void ValueShouldReturnSameReference()
        {
            object obj = new object();
            Scalar<object> scalar = new ValueItem<object>(obj);

            scalar.Value().Should().Be(obj);
        }
    }
}
