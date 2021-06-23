using System;
using System.Collections.Generic;

namespace leet_code_challenges
{

    /// <summary>
    /// Given an array of integers , find two numbers such that 
    /// they add up to a specific target number
    /// </summary>
    public class TwoSumProblem
    {
        public (int, int) TwoSumBruteForce(int[] numbers, int targetSum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == targetSum) return (i + 1, j + 1);
                }
            }

            throw new ApplicationException("No match found");

        }

        /// <summary>
        /// Given an array of integers , find two numbers such that 
        /// they add up to a specific target number. The time complexity should be O(n) 
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public (int, int) TwoSumOptimized(int[] numbers, int targetSum)
        {
            var numbersDictionary = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbersDictionary.TryGetValue(targetSum - numbers[i], out int pos))
                {
                    return (pos + 1, i + 1);
                }
                else
                {
                    numbersDictionary.Add(numbers[i], i);
                }
            }
            throw new ApplicationException("No match found");
        }
    }
}
