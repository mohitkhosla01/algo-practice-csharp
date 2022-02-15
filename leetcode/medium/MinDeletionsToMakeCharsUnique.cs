using System;
using System.Collections.Generic;

namespace algo_practice_csharp.leetcode.medium
{
    public class MinDeletionsToMakeCharsUnique
    {
        public static void Main(string[] args)
        {
            MinDeletionsToMakeCharsUnique obj = new MinDeletionsToMakeCharsUnique();

            Console.WriteLine(obj.MinDeletions("aab"));
            Console.WriteLine(obj.MinDeletions("aaabbbcc"));
            Console.WriteLine(obj.MinDeletions("ceabaacb"));

            Console.WriteLine(obj.MinDeletions("aaaaa"));
            Console.WriteLine(obj.MinDeletions("aaabbb"));
            Console.WriteLine(obj.MinDeletions("q"));
            Console.WriteLine(obj.MinDeletions("asasasasasas"));
            Console.WriteLine(obj.MinDeletions("asdasdasd"));
            Console.WriteLine(obj.MinDeletions("aaabbbccc"));
        }

        public int MinDeletions(string s)
        {
            Dictionary<char, int> charFreq = new Dictionary<char, int>();
            for(int i=0; i<s.Length; ++i)
            {
                if(charFreq.ContainsKey(s[i]))
                {
                    ++charFreq[s[i]]; 
                }
                else
                {
                    charFreq[s[i]] = 1;
                }
            }

            int c = 0;
            HashSet<int> freq = new HashSet<int>();

            foreach (KeyValuePair<char, int> entry in charFreq)
            {
                if(freq.Contains(entry.Value))
                {
                    int t = entry.Value;
                    while(t != 0)
                    {
                        if(!freq.Contains(--t))
                        {
                            break;
                        }
                    }
                    freq.Add(t);
                    c += entry.Value - t;
                }
                else
                {
                    freq.Add(entry.Value);
                }
            }

            return c;
        }
    }
}
