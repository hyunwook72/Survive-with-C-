using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DataType4
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World!";
            string str3 = str1 + str2;
            string str4 = "program" + "ming";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]);

            if (str3 == "Hello World!")
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            string str5 = "Hello World!";
            Console.WriteLine("문자 개수: {0}", str5.Length);

            string str6 = "C:\\temp\\test.txt";
            string str7 = @"c:\temp\text.txt";
            Console.WriteLine("{0} {1}", str6, str7);

            Console.ReadKey();
        }
    }
}
