using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticNoReturnType
{
    class Functions
    {
        public string s = "Anusha";
        public int i = 24;
        public char c = 'C';

        public void Fun()
        {
            Console.WriteLine("My name is:" + s);
            Console.WriteLine("My age is:" + i);
            Console.WriteLine("My surname is:" + c);
        }
    }
}
