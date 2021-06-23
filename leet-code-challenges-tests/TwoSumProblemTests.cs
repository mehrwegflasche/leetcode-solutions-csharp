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
            var testArray = new int[] { 2, 3, 5, 6, 7 };
            var (num1, num2) = twoSumProblem.TwoSumBruteForce(testArray, 10);

            Assert.AreEqual(num1, 2);
            Assert.AreEqual(num2, 5);
        }
    }
}