using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Conversion2
    {
        static void Main(string[] args)
        {
            int i = 123;
            object obj = i;
            Console.WriteLine("{0}", (int)obj);

            int j = 123;
            object o = j;
            j = 456;
            Console.WriteLine("{0} {1}", j, (int)o);

            Console.ReadKey();

        }
    }
}
