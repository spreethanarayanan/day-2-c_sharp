using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    public struct Person
    {
        public string name { get; set; }
        public Person(string _name)
        {
         name= _name;
            }
    }
    public struct Dog
    {
        public string breed { get; set; }
        public Dog(string _breed)
        {
            breed = _breed;

        }
    }
    class Class5
    {
        public static void showvalue(Object o)
        {
            if (o is Person p)
            {
                Console.WriteLine(p.name);
            }
            else if (o is Dog d) 
            {
                Console.WriteLine(d.breed);
            }
        }
        static void Main()
        {
            Object o = new Person("Preetha");
            showvalue(o);
            o = new Dog("husky");
            showvalue(o);
            Console.ReadLine();

        }
    }
}
