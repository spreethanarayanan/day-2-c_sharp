using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class Dog
    {
        public void speak()
        { 
            Console.WriteLine("bark ");
        }
    }
    class Class7
    {
        static void Main()
        {
            Object o = new Dog();
            Dog dog= o as Dog;
            if (dog != null)
                dog.speak();
            Console.ReadLine();

        }
    }
}
