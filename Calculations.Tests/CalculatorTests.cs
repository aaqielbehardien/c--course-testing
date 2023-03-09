using System;
using System.Collections.Generic;
using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void add_GivenTwoIntValues_ReturnsInt() {
            var calc = new Calculator();
            var result = calc.add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void addDouble_GiveTwoDoubleValues_ReturnsDouble() {
            var calc = new Calculator();
            var result = calc.addDouble(10, 2.0);
            Assert.IsType<double>(result);
            Assert.Equal(12, result, 1);
        }

        [Fact]
        public void FiboNochiSequenceNotIncludeZero() {
            var calc = new Calculator();
            Assert.All(calc.FiboNochiSequence, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboNochiSequenceInclude13()
        {
            var calc = new Calculator();
            Assert.Contains(13, calc.FiboNochiSequence);
        }

        [Fact]
        public void FiboNochiSequenceNotInclude4()
        {
            var calc = new Calculator();
            Assert.DoesNotContain(4, calc.FiboNochiSequence);
        }

        [Fact]
        public void checkCollection()
        {
            var calc = new Calculator();
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            Assert.Equal(expectedCollection, calc.FiboNochiSequence);
        }
    }
}
