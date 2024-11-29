using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A054_TimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("숫자입력:");
            int s = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= s; i++) 
            {
                int fact = 1;
                for (int j = 1; j <= i; j++) 
                {
                    fact *= j;
                }
                sum += fact;
            }
            Console.WriteLine("{0}",sum);*/

            /*            for (int i = 1; i <= 9; i++)
                        {
                            for (int j = 1; j <= 9; j++)
                            {
                                Console.Write("{0,3}x{1} = {2,2}", j, i, j * i);
                            }
                            Console.WriteLine();
                        }*/

            int j = 0;
            int primes = 0;

            for(int i = 1; i<=1000; i++)
            {
                for(j=2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        break;
                    }

                }
                if (i == j)
                {
                    primes++;
                    Console.Write("{0,6}{1}", i, primes % 15 == 0 ? "\n" : "");
                }
            }
            Console.WriteLine();
            Console.WriteLine("2부터 1000 사이의 소수 갯수:{0}", primes);
        }
    }
}
