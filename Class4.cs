using System;
using System.Collections.Generic;
using System.Text;

namespace day2_programs
{
    class Author
    {
        public string Name;
        public int rank;
    }
    class Exp
    {
        public string Name2;
        public int rank2;
        static void Main()
        {
            Exp exp = new Exp();
            Author author = new Author();
            bool result;
            result = author is Author;
            Console.WriteLine(result);
        }
    }
}
