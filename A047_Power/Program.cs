using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A047_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("x의 y승을 구합니다.");

            Console.Write("x를 쓰시오 : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y를 쓰시오 : ");
            int y = int.Parse(Console.ReadLine());

            int pow = 1;

            for (int i = 0; i < y; i++) 
            {
                pow *= x;
            }
            Console.WriteLine("{0}의{1}승은{2}입니다,",x,y,pow);*/


            /*Console.WriteLine("s의 팩토리얼을 구합니다.");

            Console.Write("s를 쓰시오 : ");
            int s = int.Parse(Console.ReadLine());

            int fact = 1;


            for (int i = s; i > 1; i--)
            {
                fact *= i;
            }

            Console.WriteLine("{0}! = {1}",s,fact);*/

            Console.WriteLine("소수인지를 구한다.");

            Console.Write("숫자를 쓰시오 : ");
            int h = int.Parse(Console.ReadLine());

            int index;

            for (index = 2; index < h; index++) 
            {
                if(h%index == 0)
                {
                    Console.WriteLine("{0}은 소수가 아닙니다.",h);
                    break;
                }    

            }
            if(index == h)
            {
                Console.WriteLine("{0}은 소수입니다.",h);
            }
        }
    }
}
