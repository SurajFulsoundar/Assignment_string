using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _15th_assign
    {
        // 15.	Write a C# program to find the duplicate words and their number of occurrences in a string.
        static void Main(string[] args)
        {
            string str1 = "This is a test string. This is a test string again.";
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string[] words = str1.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (wordCount.ContainsKey(words[i]))
                {
                    wordCount[words[i]]++;
                }
                else
                {
                    wordCount.Add(words[i], 1);
                }
            }

            foreach (KeyValuePair<string, int> kvp in wordCount)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
   
}

