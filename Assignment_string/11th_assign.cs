using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _11th_assign
    {
        // 11.	Write a C# program to reverse order of words in a given string.
        static void Main(string[] args)
        {
            string str1 = "This is a test string";
            string[] words = str1.Split(' ');
            string reversedString = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedString += words[i] + " ";
            }

            Console.WriteLine("The reversed order of the words is: " + reversedString);
        }
    }
}
