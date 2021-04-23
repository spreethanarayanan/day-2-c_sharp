using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class Class9
    {
        static void Main()
        {
            Console.WriteLine("enter name");
           string input= Console.ReadLine();
           char[]revarray=new char[input.Length];
            for(int i= input.Length-1; i>=0;i--)
            {
                revarray[i] = input[i];
                    //Console.WriteLine(sample[i]);
            }
            string reversed = new string(revarray);
            if(reversed == input)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("re enter");
            }
            Console.ReadLine();

        }
    }
}
