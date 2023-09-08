using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _13th_assign
    {
        // 13.	Write a C# program to find total number of alphabets, digits or special character in a string.
        static void Main(string[] args)
        {
            string str1 = "This is a test string 123@#$%";
            int alphabets = 0;
            int digits = 0;
            int specialCharacters = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];

                if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
                {
                    alphabets++;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    digits++;
                }
                else
                {
                    specialCharacters++;
                }
            }

            Console.WriteLine("The number of alphabets is: " + alphabets);
            Console.WriteLine("The number of digits is: " + digits);
            Console.WriteLine("The number of special characters is: " + specialCharacters);
        }
    }
    
}

