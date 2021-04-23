using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class Class12
    {
        public static void addstring(string s1,string s2,string s3)
        {
            Console.Write(s1 + s2 + s3);
        }
        static void Main()
        {
            addstring(s1: "preetha", s2: "  ", s3: "narayanan");
            Console.ReadLine();
        }
    }
}
