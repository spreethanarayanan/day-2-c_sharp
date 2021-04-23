using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class swap
    {
        void swapcomp(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("inside swap");
            Console.WriteLine("a=" +a);
            Console.WriteLine("b="+b);
        }
        static void Main(string[] args)
        {
            swap Swap = new swap();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Swap.swapcomp(a, b);
            Console.WriteLine("outside swap");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadLine();
        }
    }

}
