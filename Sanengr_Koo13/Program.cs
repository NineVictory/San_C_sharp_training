using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(max);

            Decimal d = 1129.20m;

            Console.WriteLine("현재 원달러 환율은 {0}입니다.", d);
            Console.WriteLine("현재 원달러 환율은 {0:C}입니다.", d);
            Console.WriteLine("현재 원달러 환율은 {0:C3}입니다.", d);  // C뒤에 숫자는 소수점 자리를 말한다.
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

            Console.WriteLine("오늘의 날짜는 {0:d} 시간은 오후{0:t}입니다.",DateTime.Now); //매개변수가 1개이기 때문에 0을 2개 쓰는게 맞음. 헷갈리지 말것

            //TimeSpan: 시간 간격(기간)을 나타내는 구조체
            TimeSpan duration = new TimeSpan(1, 12, 23, 62); //1일 12시간 23분 62초로 표현해 사용.
            string output = String.Format("소요시간: {0:c}", duration);
            Console.WriteLine(output); //소요시간: 1.12:24:02 => 62초기 때문에 1분이 증가한것으로 반영됨

        }
    }
}
