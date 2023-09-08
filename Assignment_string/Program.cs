using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class Program
    {
        //  WAP to split string into 2 tokens where string is “HELLO$WORLD”.
        static void Main(string[] args)
        {
           
            string st = " HELLO$WORLD ";
            string[] sarray = st.Split('$');
            Console.WriteLine(sarray[0]);
            Console.WriteLine(sarray[1]);


        }
    }
}
