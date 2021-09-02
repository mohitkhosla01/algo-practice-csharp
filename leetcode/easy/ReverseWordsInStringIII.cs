using System;
using System.Text;

namespace algo_practice_csharp.leetcode.easy
{
    public class ReverseWordsInStringIII
    {
        private void Main(string[] args)
        {
            ReverseWordsInStringIII reverseWordsInStringIII = new ReverseWordsInStringIII();

            Console.WriteLine(reverseWordsInStringIII.ReverseWords("Let's take LeetCode contest"));
            Console.WriteLine(reverseWordsInStringIII.ReverseWords("God Ding"));

            Console.WriteLine(reverseWordsInStringIII.ReverseWords("I am a good boy"));
            Console.WriteLine(reverseWordsInStringIII.ReverseWords("malayalam"));
            Console.WriteLine(reverseWordsInStringIII.ReverseWords("nitin malayalam"));
            Console.WriteLine(reverseWordsInStringIII.ReverseWords("a"));
            Console.WriteLine(reverseWordsInStringIII.ReverseWords("ab"));
            Console.WriteLine(reverseWordsInStringIII.ReverseWords("aba"));
        }

        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] sWords = s.Split(" ");

            for(int i=0; i<sWords.Length; ++i)
            {
                sb.Append(Reverse(sWords[i]));
                if(i != sWords.Length - 1)
                {
                    sb.Append(" ");
                }               
            }

            return sb.ToString();
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
