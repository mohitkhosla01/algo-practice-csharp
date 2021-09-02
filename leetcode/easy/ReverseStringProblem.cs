using System;

namespace algo_practice_csharp.leetcode.easy
{
    public class ReverseStringProblem
    {
        private void Main(string[] args)
        {
            ReverseStringProblem reverseStringProblem = new ReverseStringProblem();

            char[] s1 = { 'h', 'e', 'l', 'l', 'o' };
            reverseStringProblem.ReverseString(s1);
            Console.WriteLine(string.Join(",", s1));

            char[] s2 = { 'H', 'a', 'n', 'n', 'a', 'h' };
            reverseStringProblem.ReverseString(s2);
            Console.WriteLine(string.Join(",", s2));

            char[] s11 = { 'A' };
            reverseStringProblem.ReverseString(s11);
            Console.WriteLine(string.Join(",", s11));

            char[] s12 = { 'A', 'A' };
            reverseStringProblem.ReverseString(s12);
            Console.WriteLine(string.Join(",", s12));
        }

        public void ReverseString(char[] s)
        {
            for(int i=0; i<s.Length/2; ++i)
            {
                char temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }
    }
}
