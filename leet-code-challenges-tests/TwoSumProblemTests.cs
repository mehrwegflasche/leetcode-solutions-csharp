using NUnit.Framework;
using leet_code_challenges;
using System;

namespace leet_code_challenges_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TwoSumBruteForceTest()
        {
            var twoSumProblem = new TwoSumProblem();
            var testArray = new int[] { 5, 7, 2, 15, 6, 3 };
            var (num1, num2) = twoSumProblem.TwoSumBruteForce(testArray, 20);

            Assert.AreEqual(num1, 1);
            Assert.AreEqual(num2, 4);
        }

        [Test]
        public void TwoSumOptimizedTest()
        {
            var twoSumProblem = new TwoSumProblem();
            var testArray = new int[] { 5, 7, 2, 15, 6, 3 };
            var (num1, num2) = twoSumProblem.TwoSumOptimized(testArray, 20);

            Assert.AreEqual(num1, 1);
            Assert.AreEqual(num2, 4);
        }
    }
}