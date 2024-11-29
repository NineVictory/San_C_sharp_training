using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanengr_Koo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

            Console.WriteLine("float:{0}\n" +
                "double:{1}\n" +
                "decimal:{2}",flt,dbl,dcm);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"float:{flt}\n" +
                $"double:{dbl}\n" +
                $"decimal:{dcm}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("float : {0} bytes\n double : {1} bytes\n decimal : {2} bytes",
                sizeof(float), sizeof(double), sizeof(decimal)); //sizeof는 자료형의 크기를 반환한다.
              
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("{0}\n{1}",float.MinValue, float.MaxValue);
            Console.WriteLine("{0}~{1}", float.MinValue, float.MaxValue);
        }
    }
}
