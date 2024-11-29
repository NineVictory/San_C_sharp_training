using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanengr_Koo15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("스트링빌터 테스트.");
            Console.WriteLine("{0} ({1} characters)",sb.ToString(),sb.Length);//스트링빌터 테스트. (10 characters)

            sb.Clear(); //StringBuilder 객체에 모든 문자열을 지운다.
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);//(0 characters)

            sb.Append("새로운 스트링"); // 객체끝에 새로운 문자열 추가
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);//새로운 스트링 (7 characters)

            sb.Insert(5, "xyz", 2); //5번쨰 인덱스에 xyz를 2번 삽입
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);//새로운 스xyzxyz트링 (13 characters)

            Console.WriteLine("---------------------------------------------------------------------------------");

            Stopwatch time = new Stopwatch();                       //코드 실행 시간을 측정하는 데 사용
            string test = string.Empty;
            time.Start();
            for (int i = 0; i < 100000; i++)                        //0부터 99,999까지의 숫자를 문자열로 변환하여 test에 추가
            {
                test += i; //string은 불변(immutable)
                           //즉, 문자열을 수정할 때마다 새로운 문자열 객체가 생성되고 이전 문자열은 폐기 => 성능저하
            }
            time.Stop();
            Console.WriteLine("String: " + time.ElapsedMilliseconds + " ms"); //String: 19422 ms

            Console.WriteLine("---------------------------------------------------------------------------------");

            StringBuilder test1 = new StringBuilder(); 
            time.Reset();
            time.Start();
            for (int i = 0; i < 100000; i++)
            {
                test1.Append(i);//StringBuilder는 내부적으로 가변(mutable) 구조
                                //문자열을 추가할 때 기존의 문자열을 변경하지 않고 내부 버퍼에 저장 => 성능향상
            }
            time.Stop();
            Console.WriteLine("StringBuilder: " + time.ElapsedMilliseconds + " ms"); //StringBuilder: 13 ms

        }
    }
}
