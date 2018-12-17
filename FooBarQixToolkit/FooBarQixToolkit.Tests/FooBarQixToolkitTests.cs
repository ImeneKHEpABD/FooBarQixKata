using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit.Tests
{
    public class FooBarQixToolkitTests
    {
        [TestCase("1", "1")]
        [TestCase("2", "2")]
        [TestCase("8", "8")]
        public void should_return_number_when_input_is_regular_number(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("9", "Foo")]
        [TestCase("96", "Foo")]
        [TestCase("24", "Foo")]
        public void should_return_string_that_contains_only_one_Foo_when_input_is_only_divisible_by_3(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }
    }
}
