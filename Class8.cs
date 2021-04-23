using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class Class8
    {
        static void Main()
        {
            object str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(values);
            Console.WriteLine("using equality :" + (str == str2));
            Console.WriteLine("Using equals() method :" + str.Equals(str2));
            Console.ReadLine();
        }
    }
}
