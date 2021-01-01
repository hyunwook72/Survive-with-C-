using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class StandardInput3
    {
        static void Main(string[] args)
        {
            int Kor, Eng, Math, Total;
            float Average;

            Console.Write("Korean Score : ");
            Kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("English Score : ");
            Eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Math Score : ");
            Math = Convert.ToInt32(Console.ReadLine());
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
            Console.WriteLine("{0} {1} {2} {3} {4:f1}", Kor, Eng, Math, Total, Average);

            Console.ReadKey();
        }
    }
}
