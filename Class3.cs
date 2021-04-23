using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class convert 
    {
        static void Main()
        {
            Console.WriteLine("ENTER");
            var a = Console.ReadLine();
            int result;
            int.TryParse(a, out result);
            if(result==0)
            {
                Console.WriteLine("not a number");
            }
            else
            {
                Console.WriteLine("NUMBER");
            }
                      Console.ReadLine();
        }
    }
}
