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

        [TestCase("13", "Foo")]
        [TestCase("32", "Foo")]
        public void should_return_string_that_contains_only_one_Foo_when_input_only_contains_only_3(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("3", "FooFoo")]
        [TestCase("33", "FooFooFoo")]

        public void should_return_string_that_contains_multiple_Foo_when_input_contains_at_least_one_3_and_is_divisisble_by_3(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("10", "Bar")]
        public void should_return_string_that_contains_only_one_Bar_when_input_is_only_divisible_by_5(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("5", "BarBar")]
        [TestCase("25", "BarBar")]
        public void should_return_string_that_contains_multiple_Bar_when_input_string_is_divisible_by_5_and_contains_5(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("28", "Qix")]
        public void should_return_string_that_contains_only_one_Qix_when_input_string_is_only_divisible_by_7(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("17", "Qix")]
        [TestCase("47", "Qix")]
        public void should_return_string_that_contains_only_one_Qix_when_input_string_contains_only_one_7(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("7", "QixQix")]
        [TestCase("77", "QixQixQix")]
        public void should_return_string_that_contains_multiple_Qix_when_input_is_divisible_by_7_and_contains_7(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("53", "BarFoo")]
        public void should_return_string_that_contains_respectively_Bar_and_Foo_when_input_contains_respectively_5_and_3(string number, string expected)
        {
            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("21", "FooQix")]
        [TestCase("51", "FooBar")]
        [TestCase("15", "FooBarBar")]
        public void should_return_string_that_contains_respectively_Foo_Bar_or_Qix_when_input_is_divisible_by_3_5_or_7(string number, string expected)
        {

            var computed = new FooBarQix().Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }












    }
}
