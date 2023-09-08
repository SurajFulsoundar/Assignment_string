using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _10th_assgn
    {
        // Write a C# program to find reverse of a string.
        static void Main(string[] args)
        {
            

                string str1 = "This is a test string";
            string reversedString = "";

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                reversedString += str1[i];
            }

            Console.WriteLine("The reverse of the string is: " + reversedString);
        }
    }
}
