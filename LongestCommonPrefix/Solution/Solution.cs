using System.Diagnostics;

namespace LeetCode.LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] answerStrings)
        {
            GC.Collect();
            string answer = "";
            int smallIndex = answerStrings.Min(word => word.Length);

            if (answerStrings.Count() < 2)
            {
                return answerStrings[0];
            }

            for (int letterIndex = 0; letterIndex < smallIndex; letterIndex++)
            {
                int answerCount = 0;

                for (int wordIndex = 1; wordIndex < answerStrings.Count(); wordIndex++)
                {
                    if (answerStrings[0][letterIndex] == answerStrings[wordIndex][letterIndex])
                    {
                        answerCount++;
                    } 
                    else
                    {
                        return answer;
                    }
                    if (answerCount == answerStrings.Count() - 1)
                    {
                        answer += answerStrings[0][letterIndex];
                    }
                }

            }

            GC.Collect();
            return answer;
        }
    }
}