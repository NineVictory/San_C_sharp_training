using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("원하는 숫자를 입력하시오 : ");
            int input = Convert.ToInt32(Console.ReadLine());

            string result = input > 0 ? "양수입니다" : "음수입니다"; //괄호 생략가능한듯
            string result2 = (input > 0) ? "양수입니다" : "음수입니다";
            Console.WriteLine("{0}은 {1}입니다.", input, result);
            Console.WriteLine("{0}은 {1}입니다.", input, result2);

            Console.WriteLine("{0}은 {1}입니다", input, input > 0 ? "양수입니다" : "음수입니다.");

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0,3}{1}", i, i % 10 != 0 ? "" : "\n");



            }
            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0}{1}", i, i % 10 == 0 ? "\n" : "");
            }
        }
    }
}
