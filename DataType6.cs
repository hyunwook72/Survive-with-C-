using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class DataType6
    {
        static void Main(string[] args)
        {
            int? Num1 = null;

            if (Num1.HasValue)
                Console.WriteLine("Correct Value");
            else
                Console.WriteLine("null Value");

            Console.WriteLine("null : {0}", Num1);

            Console.ReadKey();
        }
    }
}
