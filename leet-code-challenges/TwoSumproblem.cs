using System;

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
    }
}
