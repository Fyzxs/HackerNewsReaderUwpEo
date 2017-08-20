using FluentAssertions;
using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Scalars;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HackerNewsUwpEo.Tests.CactooSharp.Scalars
{
    [TestClass]
    public class NotNullTests
    {
        [TestMethod]
        public void ValueShouldThrowExceptionGivenNullValue()
        {
            Scalar<object> scalar = new NotNull<object>(new ValueItem<object>(null));
            Action action = () => scalar.Value();
            action.ShouldThrow<Exception>().WithMessage("NULL instead of valid value");
        }

        [TestMethod]
        public void ValueShouldThrowExceptionGivenNullScalar()
        {
            Scalar<object> scalar = new NotNull<object>(null);
            Action action = () => scalar.Value();
            action.ShouldThrow<Exception>().WithMessage("NULL instead of valid scalar");
        }

        [TestMethod]
        public void ValueShouldThrowExceptionGivenValidValue()
        {
            object actual = new object();
            Scalar<object> scalar = new NotNull<object>(actual);
            object expected = scalar.Value();
            expected.Should().BeSameAs(actual);

        }
    }
}
