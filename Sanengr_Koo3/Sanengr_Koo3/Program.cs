using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = 1;
            double two = 1.23;

            //Console.WriteLine(one + two);

            //에러발생
            //Console.WriteLine(one,two);


            Console.WriteLine(one.ToString() + "," + two.ToString());

            Console.WriteLine("one = " + one + ", two = " + two);

            Console.WriteLine("{0} , {1}", one,two);

            Console.WriteLine($"{one} , {two}");

          
        }
    }
}
