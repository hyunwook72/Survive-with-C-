using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 사용자가 누를 키를 화면에 출력하되 Escape 키가 입력되면 프로그램을 종료
namespace ConsoleApp3
{
    class StandardInput1
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo KeyInfo;
            do
            {
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.A)
                    Console.WriteLine("You Pressd A"); // 대소문자 구별 못함
            } while (KeyInfo.Key != ConsoleKey.A);

            Console.ReadKey();
        }
    }
}
