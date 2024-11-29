using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo07
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int x,y;
            Console.WriteLine("첫번째숫자를 입력:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("두번째숫자를 입력:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}",x,y,x+y);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("2,8,10,16진수 출력");

            short value = short.MaxValue; //32767

            int basenum = 2;
            string s = Convert.ToString(value,basenum); //value값을 basenum진수 즉 2진수로 변환한다는 뜻.
                                                        //문자열11111111111이 된다.
            int i = Convert.ToInt32(s,basenum); //문자열 1111111111을 다시 정수 32767로 만듬.
            Console.WriteLine("i = {0}, {1,2}진수={2,16}",i,basenum,s);
            Console.WriteLine("i = {0}, {1}진수={2}", i, basenum, s); //{1}과{1,2} and {2}와{2,16}은 그냥 띄어쓰기라고 생각하면됨.
            Console.WriteLine("------------------------------------------------------");
            //String.Format생략해도 결과는 같음.
            int age = 30;
            Console.WriteLine("I am {0} years old.", age);
            int age2 = 30;
            Console.WriteLine(String.Format("I am {0} years old.", age2));

            string a = String.Format("I am {0} years old.", age2);
            Console.WriteLine(a);
        }
    }
}
