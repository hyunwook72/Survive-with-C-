using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DataType2
    {
        static void Main(string[] args)
        {
            char Mun = '7';
            int Num = Mun;
            Num = Num + 1;
            Console.WriteLine("Mun = {0} 문자상수값 = {1} 유니코드문자 = {2}",
                (int)Mun, Num, (char)Num);
        }
    }
}
