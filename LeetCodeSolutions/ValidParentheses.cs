using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class ValidParentheses
    {
        public ValidParentheses()
        {
        }
        public bool IsValid(string s)
        {
            List<char> openStr = new List<char>();
            string openList = "({[";
            string closeList = ")}]";
            foreach(char c in s)
            {
                if (openList.IndexOf(c) >= 0)
                {
                    openStr.Add(c);
                }
                else
                {
                    char openc = openList[closeList.IndexOf(c)];
                    if (openStr.Count == 0) return false;
                    if (openStr[openStr.Count - 1] != openc) return false;
                    openStr.RemoveAt(openStr.Count - 1);
                }
            }
            return openStr.Count == 0;
        }
    }
}
