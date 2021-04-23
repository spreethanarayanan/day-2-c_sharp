using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class Class11
    {
        static void Main()
        {
            int count = 0;
            Console.WriteLine("enter ");
            string input = Console.ReadLine();
            Console.WriteLine("letter");
            String letter=Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == Convert.ToChar(letter))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
       
    }
}
