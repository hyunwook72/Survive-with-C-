using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class DataType5
    {
        static void Main(string[] args)
        {
            var value1 = 3.14f; // 3.14f = float , 3.14 = double
            float value2 = 10.0f;
            float sum = value1 + value2;
            Console.WriteLine("{0} {1:f1} {2}", value1, value2, sum);
            //f1 : 소수점 한자리만 보여줌
            Console.ReadKey();
        }
    }
}
