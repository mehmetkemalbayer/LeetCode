using System;
namespace LeetCodeSolutions
{
    public class LongestCommonPrefixProblem
    {
        public LongestCommonPrefixProblem()
        {
        }

        public string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            return search(strs);
                        
        }
        public string search(string[] strs)
        {
            string result = String.Empty;
            string firstWord = strs[0];
            string lastWord = strs[strs.Length - 1];
            for (int i = 0; i < firstWord.Length; i++)
            {
                char toBeFound = firstWord[i];                
                if (lastWord[i] != toBeFound) return result;                                    
                result += toBeFound;
            }
            return result;
        }
    }
}
