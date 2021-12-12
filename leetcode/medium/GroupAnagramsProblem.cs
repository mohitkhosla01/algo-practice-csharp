using System;
using System.Collections.Generic;

namespace algo_practice_csharp.leetcode.medium
{
    public class GroupAnagramsProblem
    {
        private void Main(string[] args)
        {
            GroupAnagramsProblem groupAnagramsProblem = new GroupAnagramsProblem();

            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            // string[] strs = { };
            // string[] strs = { "a" };
            // string[] strs = { "aba", "abb", "bbb", "bab", "aab", "aaa", "baa", "bba" };
            // string[] strs = { "cab", "tin", "pew", "duh", "may", "ill", "buy", "bar", "max", "doc" };

            IList<IList<string>> anagrams = groupAnagramsProblem.GroupAnagrams(strs);

            foreach (IList<string> anagramList in anagrams)
            {
                foreach (string anagramString in anagramList)
                {
                    Console.WriteLine(anagramString);
                }
                Console.WriteLine();
            }
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> anagramDictionary = new Dictionary<string, List<string>>();

            foreach(string s in strs)
            {
                char[] sChar = s.ToCharArray();
                Array.Sort(sChar);
                string sSort = string.Join("", sChar);

                List<string> words = anagramDictionary.ContainsKey(sSort) ? anagramDictionary[sSort] : new List<string>();
                words.Add(s);
                anagramDictionary[sSort] = words;
            }

            IList<IList<string>> anagramWords = new List<IList<string>>();

            foreach (KeyValuePair<string, List<string>> entry in anagramDictionary)
            {
                anagramWords.Add(entry.Value);
            }

            return anagramWords;
        }
    }
}
