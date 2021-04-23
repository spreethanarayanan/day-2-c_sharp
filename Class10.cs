using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class Class10
    {
        static void Main()
        {
            Console.WriteLine("enter ");
            string input = Console.ReadLine();
            int a = 0;
            for(int i=0;i<input.Length;i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u') 
                {
                    a++;
                }
            }
            Console.WriteLine(a);
        }
       
    }
}
