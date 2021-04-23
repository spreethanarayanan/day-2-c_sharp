using System;

namespace day2_programs
{
    class Class1
       
    {
        void odd_even(int a)
        {             
                if(a%2==0)
            {
                Console.WriteLine("even");
            }
                else
            {
                Console.WriteLine("odd");
            }
        }
        static void Main(string[] args)
        {
            Class1.class = new Class1();
            class.odd_even(6);
            Console.ReadLine();
                
        }
    }
}
