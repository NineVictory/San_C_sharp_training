using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int value;
            Console.WriteLine("int로 변환할 문자열 입력:");
            string input = Console.ReadLine();

            bool result = Int32.TryParse(input, out value);

            if(!result) {
                Console.WriteLine($"{input}은 int로 변환불가능");
                }
            else
            {
                Console.WriteLine($"당신이 입력한 {input}는 int {value}로 변환되었습니다.");
            }
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("double로 변환할 문자열 입력 2번째");

            input = Console.ReadLine();
            try
            {
                double b = double.Parse(input);
                Console.WriteLine("double {0}으로 변환되었습니다.",b);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
