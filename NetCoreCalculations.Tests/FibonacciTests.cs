﻿using System.Collections.Generic;
using Xunit;

namespace NetCoreCalculations.Tests
{
    public class FibonacciTests
    {
        [Fact]
        public void FiboNumbersDoesNotIncludeZero()
        {
            var fibo = new Fibonacci();
            Assert.All(fibo.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboNumbersIncludesAtLeast13()
        {
            var fibo = new Fibonacci();
            Assert.Contains(13, fibo.FiboNumbers);
        }

        [Fact]
        public void FiboNumbersDoesNotInclude4()
        {
            var fibo = new Fibonacci();
            Assert.DoesNotContain(4, fibo.FiboNumbers);
        }

        [Fact]
        public void CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var fibo = new Fibonacci();
            Assert.Equal(expectedCollection, fibo.FiboNumbers);
        }
    }
}
