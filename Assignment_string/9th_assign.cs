using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _9th_assign
    {
        // 9.	Write a C# program to count total number of vowels and consonants in a string.
        static void Main(string[] args)
        {
            string str1 = "This is a test string";

            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }

            Console.WriteLine("The number of vowels in the string is: " + vowels);
            Console.WriteLine("The number of consonants in the string is: " + consonants);
        }
    }
    
}

