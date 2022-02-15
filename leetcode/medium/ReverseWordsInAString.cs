using System;
using System.Text.RegularExpressions;

namespace algo_practice_csharp.leetcode.medium
{
    public class ReverseWordsInAString
    {
        private void Main(string[] args)
        {
            ReverseWordsInAString obj = new ReverseWordsInAString();

            Console.WriteLine(obj.ReverseWords("the sky is blue"));
            Console.WriteLine(obj.ReverseWords("  hello world  "));
            Console.WriteLine(obj.ReverseWords("a good   example"));
        }

        public string ReverseWords(string s)
        {
            s = Regex.Replace(s, @"\s+", " ");
            string[] sArr = s.Trim().Split(" ");
            Array.Reverse(sArr);
            return string.Join(" ", sArr);
        }
    }
}
