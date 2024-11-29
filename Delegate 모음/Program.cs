using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_모음
{
    internal class Program
    {
        //(1)(2)
        delegate bool MemberTest(int a);                                //'MemberTest'라는 델리게이트 타입 정의 - 매개변수로 int를 받고 bool을 반환
                                                                        //3번은 이 CodeLine이 필요없음 => Func를 사용하기 때문 (제네릭 매개변수를 사용하기 때문)
        //(5)
        delegate double CalcMethod(double a, double b);                 //계산용 델리게이트 선언
        delegate bool IsAdult(Student student);                         //'Student' 객체가 성인인지 판단

        static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 13, 12, 15, 23, 53, 234, 67, 34, 512, 144, 513 };
            //var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 13, 12, 15, 23, 53, 234, 67, 34, 512, 144, 513 };
            Random rand = new Random();
            int [] arr = new int[22];
            for(int i  = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 600);
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            //1.Delegate의 기본
            Console.WriteLine("1.Delegate의 기본");
            Console.WriteLine();

            //아래에 Count메서드를 호출
            Console.WriteLine("짝수의 개수 :"+Count(arr,IsOdd));         // 짝수 개수 계산
            Console.WriteLine("홀수의 개수 :" + Count(arr, IsEven));     // 홀수 개수 계산

            Console.WriteLine("=============================================================================");


            //2.이름없는 델리게이트(무명 델리게이트)
            Console.WriteLine("2.이름없는 델리게이트");
            Console.WriteLine();

            // 익명 메서드를 사용하여 짝수, 홀수 개수 계산
            int NoName = Count(arr, delegate (int num) { return num % 2 == 0; });
            Console.WriteLine("짝수의 갯수는:{0}",NoName);
            NoName = Count(arr, delegate (int num) { return num % 2 == 1; });
            Console.WriteLine("홀수의 갯수는:{0}",NoName);

            Console.WriteLine("=============================================================================");


            //3.Func으로 델리게이트를 간단히 만들기
            Console.WriteLine("3.Func으로 델리게이트를 간단히 만들기");
            Console.WriteLine();

            int Noname_Func = Count_Func(arr, delegate (int num) { return num % 2 == 0; }); // Func 사용
            Console.WriteLine("짝수의 갯수는:{0}", Noname_Func);
            Noname_Func = Count_Func(arr, delegate (int num) { return num % 2 == 1; });
            Console.WriteLine("홀수의 갯수는:{0}", Noname_Func);

            Console.WriteLine("=============================================================================");


            //4.람다식
            Console.WriteLine("4.람다식");
            Console.WriteLine();

            //int Noname_Func = Count_Func(arr, delegate (int num) { return num % 2 == 0; });
            // 위에 식을 아래와 같이 바꾸는 것이 람다식.
            //int Noname_Func = Count_Func(arr, num => num%2==0);

            int Lambda = Count_Func(arr, num => num % 2 == 0);         // 람다식을 사용하여 짝수 계산
            Console.WriteLine("짝수의 갯수는:{0}", Lambda);

            Lambda = Count_Func(arr, num => num % 2 == 1);             // 람다식을 사용하여 홀수 계산
            Console.WriteLine("홀수의 갯수는:{0}", Lambda);

            Console.WriteLine("=============================================================================");

            //5.람다를 메소드처럼 사용(식 람다, 문 람다) 4번은 기존메소드에서 매개변수처럼 사용함.
            Console.WriteLine("5.람다를 메서드처럼 사용(식 람다, 문 람다)");
            Console.WriteLine();

            //5-1.int로 받아서 int로 내보내는 익명 메소드
            Console.WriteLine("int로 받아서 int로 내보내는 익명 메소드");
            Func<int,int> square = x=> x*x;
            Console.WriteLine(square(5));
            Console.WriteLine();

            //5-2.배열을 사용한 람다식
            Console.WriteLine("배열을 사용한 람다식");
            var squared_Num = arr.Select(x => x*x);                  // 배열 요소들을 제곱하는 람다식
                                                                        //Select는 Linq에서 사용하는 메소드로 컬렉션의 각 요소에 특정 변환을 적용하고,
                                                                        //변환된 결과를 새로운 컬렉션으로 반환할 때 사용
            Console.WriteLine(string.Join("|",squared_Num));         //Join은 배열이나 리스트를 하나의 문자열로 결합한다. 여기선 "|"를 기준으로 구분해서 출력.
            Console.WriteLine();

            //5-3.기존에 선언한 델리게이트 타입을 사용한 식 람다
            Console.WriteLine("기존에 선언한 델리게이트 타입을 사용한 식 람다");
            CalcMethod add = (a,b) => a + b;
            CalcMethod subtract = (a, b) => a - b;

            Console.WriteLine(add(10.5,20.1));
            Console.WriteLine(subtract(10.5, 20.1));
            Console.WriteLine();

            //5-4.기존에 선언한 델리게이트 타입을 사용한 문 람다
            Console.WriteLine("기존에 선언한 델리게이트 타입을 사용한 문 람다");
            IsAdult adult = (Student s) =>                              //람다식은 매개변수의 타입이 생략이 가능하지만 타입을 유추할 수 있는 경우에만 가능함.
            {
                int adultAge = 18;                                      //성인나이를 만18세이상으로 설정
                return s.age >= adultAge;                               //18세보다 많으면 true, 적으면 false를 선언
            };

            Student s1 = new Student() {name ="Koo" , age=25};
            Console.WriteLine("{0}은(는) {1}입니다.",s1.name,adult(s1)? "성인":"미성년자");

            Console.WriteLine();
            Console.WriteLine("=============================================================================");


            //6.predicate<T> 델리게이트: 하나의 매개변수를 갖고 리턴값이 bool인 델리게이트
            Console.WriteLine("6.predicate<T> 델리게이트: 하나의 매개변수를 갖고 리턴값이 bool인 델리게이트");
            Console.WriteLine();

            //기본형식
            Predicate<int> isEven = IsEven2;                            //아래에 IsEven2라는 메서드를 생성하여 호출함.
            //Func<int, bool> isEven = IsEven2;                         //Func 델리게이트와 동일함.
            Console.WriteLine(isEven(6));                               //짝수를 구하는 메서드기 때문에 True.
               

            //람다형식 정수형
            Predicate<int> isEven2 = n => n % 2 == 0;                   //메소드를 익명 델리게이트로 사용 => 함수를 정의하지 않아도됨.
            Console.WriteLine(isEven(6));

            //람다형식 문자열
            Predicate<string> isLowerCase = S => S.Equals(S.ToLower()); //ToLower로 소문자로 만든 뒤 Equals로 같은지 비교하는 코드
            Console.WriteLine(isLowerCase("A"));                        //대문자라 false
            Console.WriteLine(isLowerCase("a"));                        //소문자라 true
            Console.WriteLine("=============================================================================");


 
        }

        //(1) 
        static public bool IsOdd(int b) { return b % 2 == 0; }          // 짝수 검사 메서드
        public static bool IsEven(int b) { return b % 2 == 1; }         // 홀수 검사 메서드

        //(1),(2) 짝수 및 홀수 계산용 메서드 - 델리게이트와 함께 사용
        static int Count(int[] a, MemberTest testMethod)
        {
            int count = 0;

            foreach(var i in a)
            {
                if (testMethod(i))
                {
                    count++;
                }
            }
            
            return count;

        }
        //(3),(4) Func를 사용한 Count 메서드
        private static int Count_Func(int[]arr, Func<int,bool> testMethod)  //Func<int,bool> : 매개변수가 int 리턴값이 bool인 
        {
            int count = 0;

            foreach (var i in arr)
            {
                if (testMethod(i))
                {
                    count++;
                }
            }
            return count;
        }

        //(5) 학생 정보 저장 클래스
        public class Student
        {
            public string name { get; set; }
            public int age { get; set; }
        }
        //(6) Predicate 사용을 위한 짝수 검사 메서드
        static bool IsEven2(int n)
        {
            return n % 2 == 0;
        }
    }
}
