using System;

namespace LeetCodeSolutions
{
    public class RomanToIntClass
    {
        public int RomanToInt(string s)
        {
            int total = 0;
            char next;
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                int addOrSubstract = 1;
                if (i + 1 == s.Length)
                {
                    next = ' ';
                }
                else
                {
                    next = s[i + 1];
                }                
                if (c == 'I' && next == 'V')
                {
                    addOrSubstract = -1;
                }
                if (c == 'I' && next == 'X')
                {
                    addOrSubstract = -1;
                }
                if (c == 'X' && next == 'L')
                {
                    addOrSubstract = -1;
                }
                if (c == 'X' && next == 'C')
                {
                    addOrSubstract = -1;
                }
                if (c == 'C' && next == 'D')
                {
                    addOrSubstract = -1;
                }
                if (c == 'C' && next == 'M')
                {
                    addOrSubstract = -1;
                }
                total += GetValue(c, addOrSubstract);
            }
            return total;
        }
        public int GetValue(char c, int addOrSubstract)
        {
            if (c == 'I') return 1 * addOrSubstract;
            if (c == 'V') return 5 * addOrSubstract;
            if (c == 'X') return 10 * addOrSubstract;
            if (c == 'L') return 50 * addOrSubstract;
            if (c == 'C') return 100 * addOrSubstract;
            if (c == 'D') return 500 * addOrSubstract;
            if (c == 'M') return 1000 * addOrSubstract;
            throw new Exception();
        }
    }
}
