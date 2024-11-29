using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("hello wolrd");

             Console.Write("이름 입력:");

             string name = Console.ReadLine();

             Console.WriteLine("당신의 이름은" + name + "입니다");

             decimal dm = 123.123m;*/

            for (int i = 0; i <= 20; i++)
                Console.WriteLine("2 ^ {0,2} = {1, 7}", i, Power(2, i));



        }
        private static int Power(int baseNumber, int exponent)
        {
            int result = 1;
            for (int j = 1; j <= exponent; j++)
                result *= baseNumber;
            return result;
        }
    }
}
