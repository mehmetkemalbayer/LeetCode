using System;
namespace LeetCodeSolutions
{
    public class StrStrProblem
    {
        public StrStrProblem()
        {
        }
        public int StrStr(string haystack, string needle)
        {
            if (needle.Equals(String.Empty)) return 0;
            return haystack.IndexOf(needle);
        }
    }
}
