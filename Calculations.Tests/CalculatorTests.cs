using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{

    public class CalculatorFixture : IDisposable { 
        public Calculator Calculator => new Calculator();

        public void Dispose() { 
            // Clean
            // Find out what to do in here
        }
    }
    public class CalculatorTests : IClassFixture<CalculatorFixture>, IDisposable
    {
        private readonly CalculatorFixture _calculatorFixture;
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MemoryStream _memoryStream;
        public CalculatorTests(CalculatorFixture calculatorFixture, ITestOutputHelper testOutputHelper) {
            _calculatorFixture = calculatorFixture;
            _testOutputHelper = testOutputHelper;

            _memoryStream = new MemoryStream();

            _testOutputHelper.WriteLine("Constructor");
        }

        public void Dispose() {
            _memoryStream.Close();
        }

        [Fact]
        public void add_GivenTwoIntValues_ReturnsInt() {
            var calc = _calculatorFixture.Calculator;
            var result = calc.add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void addDouble_GiveTwoDoubleValues_ReturnsDouble() {
            var calc = _calculatorFixture.Calculator;
            var result = calc.addDouble(10, 2.0);
            Assert.IsType<double>(result);
            Assert.Equal(12, result, 1);
        }

        [Fact]
        public void FiboNochiSequenceNotIncludeZero() {
            var calc = _calculatorFixture.Calculator;
            Assert.All(calc.FiboNochiSequence, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboNochiSequenceInclude13()
        {
            _testOutputHelper.WriteLine("Checking if Fibo includes 13");
            var calc = _calculatorFixture.Calculator;
            Assert.Contains(13, calc.FiboNochiSequence);
        }

        [Fact]
        public void FiboNochiSequenceNotInclude4()
        {
            var calc = _calculatorFixture.Calculator;
            Assert.DoesNotContain(4, calc.FiboNochiSequence);
        }

        [Fact]
        public void checkCollection()
        {
            var calc = _calculatorFixture.Calculator;
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            Assert.Equal(expectedCollection, calc.FiboNochiSequence);
        }
    }
}
