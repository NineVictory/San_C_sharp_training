using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A061_RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r= new Random();

            Console.Write("{0,-16}", "랜덤byte:");
            Byte[] b = new byte[5];

            r.NextBytes(b);
            foreach (var i in b) { 
                Console.Write("{0,12}",i);
            }
            Console.WriteLine();


            Console.Write("{0,-16}", "랜덤double:");
            Double[] d = new Double[5];

            for (int i = 0; i < d.Length; i++)
            {
                d[i]= r.NextDouble();
            }
            
            foreach (var i in d)
            {
                Console.Write("{0,12:F8}", i);
            }
            Console.WriteLine();

            Console.Write("{0,-16}", "랜덤int:");
            int[] a = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next();
            }
            PrintArray(a);

        }
        private static void PrintArray(int[] h)
        {
            foreach(var i in h)
            {
                Console.Write("{0,12}",i);
            }   
            Console.WriteLine();
        }
    }
}
