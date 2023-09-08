using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class _4th_assgn
    {
        // Write a C# program to trim leading white space characters in a string.

        
        static void Main(string[] args)
        {
            string st = "HELLO$WORLD";

            string str = string.Concat(st.Trim());
            Console.WriteLine(str);

        }
    }
}
