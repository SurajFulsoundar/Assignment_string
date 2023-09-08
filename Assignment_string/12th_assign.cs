using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _12th_assign
    {
        // 12.	Write a C# program to find highest frequency character in a string.
        static void Main(string[] args)
        {
            string str1 = "This is a test string";
            int[] charCount = new int[256];
            char[] ch = str1.ToCharArray();

            for (int i = 0; i < str1.Length; i++)
            {
                char ch1 = str1[i];
                charCount[ch1]++;
            }

            int maxCount = 0;
            char maxChar = ch[0];

            for (int i = 0; i < 256; i++)
            {
                if (charCount[i] > maxCount)
                {
                    maxCount = charCount[i];
                    maxChar = (char)i;
                }
            }

            Console.WriteLine("The highest frequency character is: " + maxChar);
        }
    }
}

