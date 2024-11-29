using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;

            Console.WriteLine(10.0 / y); //예외가 아니라 무한대가 됨
            Console.WriteLine(10.0 / x);
            //Console.WriteLine(x/y); //에러코드 설명 후 0으로 나누려 했습니다. 라고 출력   
            Console.WriteLine("------------------------------------------");
            try
            {
                Console.WriteLine(x / y);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); //0으로 나누려 했습니다. 라고 출력
            }
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("int.MaxValue ={0}", int.MaxValue);

            int x2 = int.MaxValue, y2 = x2 + 10, y3 = 0;
            Console.WriteLine("int.MaxValue+10 ={0}", y2);
            Console.WriteLine("------------------------------------------");
            //overflow는 checked 키워드를 사용하면된다.
            //y2 = int.MaxValue + 10; 이 방식은 컴파일 에러가 난다

            checked
            {
                try
                {
                    y3 = x2 + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue+10 ={0}", y3);

        }
    }
}
