using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello world! ", t;

            Console.WriteLine(s); //Hello world
            Console.WriteLine(s[8]); //r
            Console.WriteLine(s.Insert(8, "C#")); //Hello woC#rld => 8번째 인덱스에 C#을 삽입
            Console.WriteLine(s.PadLeft(20, ',')); //,,,,,,,,,Hello world => 최대 갯수를 20개로 맞춘 뒤 왼쪽에 쉼표(,)로 빈공간을 채운다.
            Console.WriteLine(s.PadRight(20, ',')); //Hello world,,,,,,,,, => 최대 갯수를 20개로 맞춘 뒤 오른쪽에 쉼표(,)로 빈공간을 채운다.
            Console.WriteLine(s.Remove(6)); //Hello => 6번 인덱스 앞 내용만 보여주고 뒤에는 삭제
            Console.WriteLine(s.Remove(6, 5)); //Hello => 6번 인덱스부터 5개뒤에 문자열을 삭제한다.
            //Console.WriteLine(s.Remove(6, 7)); //s의 문자열 갯수는 11개인데 6번 인덱스 뒤에 문자열이 5개이기 때문에 5개 이상이 되면 에러가 발생
            Console.WriteLine(s.Replace('l', 'n')); //Henno wornd => s 변수 안에 l이 있으면 n으로 바꾼다
            Console.WriteLine(s.Replace("r", "m")); //Hello womld => ''로쓰든 ""로 쓰든 상관없이 작동됨
            Console.WriteLine(s.ToLower()); //hello world => s의 문자를 모두 소문자로
            Console.WriteLine(s.ToUpper()); //HELLO WORLD => s의 문자를 모두 대문자로
            Console.WriteLine(s.Trim()); // Hello world => 앞뒤 공백제거
            Console.WriteLine('/' + s.Trim() + '/'); // /Hello world/ => 앞뒤 공백제거
            Console.WriteLine('/' + s.TrimStart() + '/'); // /Hello world/ => 앞 공백제거
            Console.WriteLine('/' + s.TrimEnd() + '/'); // /Hello world/ => 뒤 공백제거

            Console.WriteLine("---------------------------------------------------------");
            string v = "he,llo, wo,rl,d";
            Console.WriteLine(v);
            string[] q = v.Split(',');
            string[] a = s.Split(',');
            foreach (var i in q)
                Console.WriteLine('/' + i + '/');


            foreach (var i in a)
                Console.WriteLine('/' + i + '/'); // /Hello world/ => 쉼표를 기준으로 구분. 다만 문장에는 쉼표가 없어서 그대로 출력 
            Console.WriteLine("---------------------------------------------------------");
            string h = "H,ello,world";
            string[] h2 = h.Split(',');
            foreach (string i in h2) //foreach는 배열로만 가능하다.
                Console.WriteLine('/' + i + '/'); //var는 변수의 타입을 자동으로 추론해주기 때문에 내가 변수를 알고있다면 string으로 써도 무관함.
            Console.WriteLine("---------------------------------------------------------");
            char[] destination = new char[10];
            s.CopyTo(6, destination, 0, 6); //CopyTo(s의 복사할 인덱스 위치,복사한 것을 저장할 목적지배열, 목적지배열에 어디인덱스부터 복사할지, s문자열에서 몇개의 문자를 복사할지);
            Console.WriteLine(destination); // world => 6번 째 인덱스부터 
            Console.WriteLine('/' + s.Substring(6) + '/'); // / world! / => 6번 인덱스부터 끝까지
            Console.WriteLine('/' + s.Substring(6, 5) + '/');// / worl/ => 6번인덱스부터 5개
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine(s.Contains("11")); //False => s안에 11이 있으면 T 없으면 F
            Console.WriteLine(s.IndexOf("o"));  //5 => o가 있는 인덱스중 가장 앞에있는 인덱스 위치 호출
            Console.WriteLine(s.LastIndexOf("o"));  //8 => 맨뒤에 있는 인덱스 위치 호출
            Console.WriteLine(s.CompareTo("abc"));  //-1 => s의 문자열과 abc를 사전식으로 비교해서 s가 빠르면 -1 같으면 0 느리면 1을 호출한다. (s는 빈칸부터 시작하기에 -1이 호출됨)
            Console.WriteLine(t = String.Copy(s)); // 위에 선언한 t를 s로 복사한다.
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine(String.Concat("Hi~", s));// Hi~ Hello world! =>정적메소드로 두개의 스트링을 합친다.
            Console.WriteLine(String.Compare("Koo", s)); // 1 => 왼쪽 문자열을 기준으로 앞에 문자와 비교해서 빠르면 -1 같으면 0 느리면 1을 호출한다
            Console.WriteLine(String.Compare(s, "Koo")); // -1  => 참고로 공백은 문자보다 빠름

            Console.WriteLine("---------------------------------------------------------");

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join("|", val); //apple|orange|grape|pear => 배열 val을 |로 연결한뒤 리턴한다.
            Console.WriteLine(result);

            Console.WriteLine("---------------------------------------------------------");
            string k = "Hello world!";
            char[] charArray = k.ToCharArray(); //문자 배열로 변환
            charArray[3] = 'n'; // 인덱스 3의 문자 변경
            string result2 = new string(charArray);
            Console.WriteLine(result2); // Henlo world!


        }

    }
}
