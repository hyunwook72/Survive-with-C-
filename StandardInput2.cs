using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class StandardInput2
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo KeyInfo;
            do
            {
                KeyInfo = Console.ReadKey(true);//true : 타자 보여줌, false : 타자 안 보여줌
                if (KeyInfo.KeyChar == 'a')
                    Console.WriteLine("a가 눌렸어");
                Console.Write(KeyInfo.KeyChar);
            } while (KeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
