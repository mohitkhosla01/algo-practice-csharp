using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algo_practice_csharp.leetcode.medium
{
    public class RemoveDuplicateLettersInString
    {
        private void Main(string[] args)
        {
            /*
             * Could not solve this problem.
             * Need to retry.
             */

            RemoveDuplicateLettersInString obj = new RemoveDuplicateLettersInString();

            Console.WriteLine("bcabc: " + obj.RemoveDuplicateLetters("bcabc"));
            // Console.WriteLine("cbacdcbc: " + obj.RemoveDuplicateLetters("cbacdcbc"));
        }

        public string RemoveDuplicateLetters(string s)
        {
            char[] sChars = s.ToCharArray();

            Dictionary<char, int> availableChars = new Dictionary<char, int>();
            LinkedList<char> newList = new LinkedList<char>();

            for (int i = 0; i < sChars.Length; ++i)
            {
                if(availableChars.ContainsKey(sChars[i]))
                {
                    int availableCharsIndex = availableChars[sChars[i]];

                    if (availableCharsIndex != newList.Count - 1)
                    {
                        if (availableCharsIndex == 0 && !(newList.ElementAt(availableCharsIndex) < newList.ElementAt(availableCharsIndex + 1)))
                        {
                            newList.Remove(sChars[i]);
                            newList.AddLast(sChars[i]);

                            availableChars.Remove(sChars[i]);
                            availableChars.Add(sChars[i], newList.Count - 1);
                        }
                        else if (!((newList.ElementAt(availableCharsIndex - 1) < newList.ElementAt(availableCharsIndex))
                            && (newList.ElementAt(availableCharsIndex) < newList.ElementAt(availableCharsIndex + 1))))
                        {
                            newList.Remove(sChars[i]);
                            newList.AddLast(sChars[i]);

                            availableChars.Remove(sChars[i]);
                            availableChars.Add(sChars[i], newList.Count - 1);
                        }
                    }
                }
                else
                {
                    newList.AddLast(sChars[i]);
                    availableChars.Add(sChars[i], i);
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach(char newChar in newList)
            {
                sb.Append(newChar);
            }

            return sb.ToString();
        }
    }
}
