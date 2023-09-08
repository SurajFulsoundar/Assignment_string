using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_string
{
    internal class assign_str

    {
        static void Main(string[] args)
        {
            string st = "HELLO$WORLD";
            string[] s = st.Split('$');

            foreach (string s2 in s)
            {
                Console.WriteLine(s2);
            }

        }

    }
}
