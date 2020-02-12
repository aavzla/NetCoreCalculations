﻿using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace NetCoreCalculations.Tests
{
    public class FibonacciTests
    {
        //This will allow to have an output for the result of the Test.
        //We use it to learn how the test are runned by XUnit regarding constructor and Disposable by logging.
        private readonly ITestOutputHelper _testOutputHelper;

        public FibonacciTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine($"Contructor {nameof(FibonacciTests)}");
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbersDoesNotIncludeZero()
        {
            _testOutputHelper.WriteLine($"{nameof(FiboNumbersDoesNotIncludeZero)}");
            var fibo = new Fibonacci();
            Assert.All(fibo.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbersIncludesAtLeast13()
        {
            _testOutputHelper.WriteLine($"{nameof(FiboNumbersIncludesAtLeast13)}");
            var fibo = new Fibonacci();
            Assert.Contains(13, fibo.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumbersDoesNotInclude4()
        {
            _testOutputHelper.WriteLine($"{nameof(FiboNumbersDoesNotInclude4)}");
            var fibo = new Fibonacci();
            Assert.DoesNotContain(4, fibo.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            _testOutputHelper.WriteLine($"{nameof(CheckCollection)}");
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var fibo = new Fibonacci();
            Assert.Equal(expectedCollection, fibo.FiboNumbers);
        }
    }
}
