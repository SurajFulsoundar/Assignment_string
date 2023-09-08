using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _5th_ass
    {
        // Write a C# program to count total number of words in a string. 
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            int countwords = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countwords++;
            }
            Console.WriteLine($"Total Words in String={countwords}");
        }
    }
}






    
