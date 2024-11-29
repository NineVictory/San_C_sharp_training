using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // 콘솔창에 있는 모든 글자를 지운다.

            decimal value = 12345678m;
            int number = 1234;
            Console.WriteLine("종류");
            Console.WriteLine(
                "{0:c}\n" +
                "{0:n}\n" +
                "{0:d}\n" +
                "{1:e}\n" +
                "{1:c}\n" +
                "{0:e}\n"
                , -12345678, -1234.5678f
                );

            Console.WriteLine(
                "잔액은 {0:C2}원 입니다", value
                );

            Console.WriteLine(
                "잔액은 {0,20:C2}원 입니다", value //20은 이 문장의 전체부분의 20을 차지하는 빈칸을 만든다.
                );
            Console.WriteLine
                ("-----------------------------------------------------------------------------------------");
            Console.WriteLine(
                "{0,-8}", value
                );

            Console.WriteLine(
                "{0,-8}", number
                );
            Console.WriteLine
                ("-----------------------------------------------------------------------------------------");
            decimal value2 = 1234m;
            //  Console.WriteLine("{0:D8}", value2);  //에러 why? decimal은 소수를 포함할 수 있는 자료형이지만 D형식 지정자는 정수만 가능.

            //int로 바꿔주거나 decimal가 아닌 정수를 사용
            Console.WriteLine("{0:D8}", (int)value2);
            Console.WriteLine("{0:D8}", 1234);
            Console.WriteLine
                ("-----------------------------------------------------------------------------------------");
            //ToString 방식으로도 사용가능
            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(value2.ToString("N2"));
            Console.WriteLine(number.ToString("D2"));
            Console.WriteLine
                ("-----------------------------------------------------------------------------------------");
            Console.WriteLine("{0:#.##}", 12345678.987654);
            Console.WriteLine("{0:0,0.00}", 12345678.987654);//숫자가 없을경우 0을 표시
            Console.WriteLine("{0:#,#.##}", 12345678.987654);//숫자가 있을 경우만 표시
            Console.WriteLine("{0:00000.00}", 1234.987654);//0이 5개인데 숫자가 5자리가 안되면 앞에 0을 추가함
            Console.WriteLine("{0:00000.00}", 12345678.987654);//0이 5개인데 숫자가 5자리보다 크면 적용안됨
            Console.WriteLine
    ("-----------------------------------------------------------------------------------------");
            //                  양수(음수);0일 때 출력되는 형식 입력값이 0이면 결과로 zero 출력
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}",1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", -1234.567); //음수는 (1234.567)로 괄호안에 값이 양수로 들어가서 출력된다.
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 0);

        }
}
}
