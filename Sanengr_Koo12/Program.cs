using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("곱하고 싶은 숫자들을 입력하세요(.으로 숫자들을 구분)");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            string[] result = s.Split('.');
            int sum = 1;
            Console.WriteLine(result);
            for (int i = 0; i < result.Length; i++) {
                try
                {
                    int num = int.Parse(result[i]);
                    sum *= num;
    }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                            
            }
            Console.WriteLine(sum);

            Console.WriteLine("더하고 싶은 숫자들을 입력하세요 (스페이스로 구분)");
            string h = Console.ReadLine();
            Console.WriteLine(h);

            int sum2 = 0;
            string[] result2 = h.Split();

            foreach (string i in result2)
            {

                sum2 += int.Parse(i);

            }
            Console.WriteLine(sum2);
        }
    }
}
