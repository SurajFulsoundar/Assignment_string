using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _7th_assign
    {
        // 7.	Write a C# program to trim trailing white space characters in a string.
        static void Main(string[] args)
        {
            string str1 = " This is a test string   ";

            string new_str = str1.TrimEnd();

            Console.WriteLine(new_str);
        }
    }
}
