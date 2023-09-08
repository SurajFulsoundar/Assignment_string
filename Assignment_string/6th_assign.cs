using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _6th_assign
    {
        // 6.	Write a C# program to remove all occurrences of a character from string.
        static void Main(string[] args)
        {
            string str1 = "This is a test string";
            char ch = 's';

            string new_str = "";
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != ch)
                {
                    new_str += str1[i];
                }
            }

            Console.WriteLine(new_str);
        }
    }
    
}

