using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.LeetCode.String
{
    class LengthOfLastWord
    {
        public int LengthOfLast_Word(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            int lengthOfLastWord = 0;
            int currentWordCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]))
                {
                    currentWordCount++;
                    lengthOfLastWord = currentWordCount;
                }
                else
                {
                    currentWordCount = 0;
                }

            }

            return lengthOfLastWord;
        }
    }
}
