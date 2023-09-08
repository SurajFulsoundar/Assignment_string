using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _8th_assign
    {
        // 8.	Write a C# program to toggle case of each character of a string.
        static void Main(string[] args)
        {
            string str1 = "This is a test string";

            string new_str = "";
            for (int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];

                if (ch >= 'a' && ch <= 'z')
                {
                    ch = (char)(ch - 'a' + 'A');
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch - 'A' + 'a');
                }

                new_str += ch;
            }

            Console.WriteLine(new_str);
        }


    }
}
