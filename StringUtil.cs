using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestFrameworksTask
{
    public class StringUtil
    {
        public static int MaxUnequalConsecutiveChars(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxConsecutiveCount = 1;
            int currentConsecutiveCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentConsecutiveCount = 1;
                }
                else
                {
                    currentConsecutiveCount++;
                    if (currentConsecutiveCount > maxConsecutiveCount)
                    {
                        maxConsecutiveCount = currentConsecutiveCount;
                    }
                }
            }

            return maxConsecutiveCount;
        }

        public static int MaxConsecuntiveLatinLetters(string input)
        {
            int maxConsecutiveCount = 0;
            int currentConsecutiveCount = 0;

            foreach (char c in input)
            {
                if (char.IsLetter(c) && char.IsLetter(currentConsecutiveCount > 0 ? input[currentConsecutiveCount - 1] : c))
                {
                    currentConsecutiveCount++;
                    if (currentConsecutiveCount > maxConsecutiveCount)
                    {
                        maxConsecutiveCount = currentConsecutiveCount;
                    }
                }
                else
                {
                    currentConsecutiveCount = 0;
                }
            }

            return maxConsecutiveCount;
        }

        public static int MaxConsecuntiveDigits(string input)
        {
            int maxConsecutiveCount = 0;
            int currentConsecutiveCount = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c) && char.IsDigit(currentConsecutiveCount > 0 ? input[currentConsecutiveCount - 1] : c))
                {
                    currentConsecutiveCount++;
                    if (currentConsecutiveCount > maxConsecutiveCount)
                    {
                        maxConsecutiveCount = currentConsecutiveCount;
                    }
                }
                else
                {
                    currentConsecutiveCount = 0;
                }
            }

            return maxConsecutiveCount;
        }
    }
}